import {inject, Injectable, signal} from '@angular/core';
import {finalize} from "rxjs";
import {map} from "rxjs/operators";
import {ActivatedRoute} from "@angular/router";
import {
  AbpTenantService,
  ConfigStateService,
  CurrentTenantDto,
  MultiTenancyService,
  SessionStateService
} from "@abp/ng.core";
import {ToasterService} from "@abp/ng.theme.shared";

@Injectable()
export class AccountLayoutService {

  private configState = inject(ConfigStateService);
  private multiTenancy = inject(MultiTenancyService);
  private toasterService = inject(ToasterService);
  private tenantService = inject(AbpTenantService);
  private sessionState = inject(SessionStateService);


  isMultiTenancyEnabled$ = this.configState.getDeep$('multiTenancy.isEnabled');
  enableLocalLogin$ = this.configState.getSetting$('Abp.Account.EnableLocalLogin')
    .pipe(map(value => value?.toLowerCase() !== 'false'));

  tenantBoxKey = 'Account.TenantBoxComponent';
  route: ActivatedRoute = inject(ActivatedRoute);


  get isTenantBoxVisibleForCurrentRoute() {
    return this.getMostInnerChild().data.tenantBoxVisible ?? true;
  }

  get isTenantBoxVisible() {
    return this.isTenantBoxVisibleForCurrentRoute && this.multiTenancy.isTenantBoxVisible;
  }


  private getMostInnerChild() {
    let child = this.route.snapshot;
    let depth = 0;
    const depthLimit = 10;
    while (child.firstChild && depth < depthLimit) {
      child = child.firstChild;
      depth++;
    }
    return child;
  }

  //
  currentTenant$ = this.sessionState.getTenant$();
  name = signal('')
  isModalVisible!: boolean;
  modalBusy!: boolean;

  onSwitch() {
    const tenant = this.sessionState.getTenant();
    this.name.set(tenant?.name || '')
    this.isModalVisible = true;
  }

  save() {
    const name = this.name()
    if (!name) {
      this.setTenant(null);
      this.isModalVisible = false;
      return;
    }

    this.modalBusy = true;
    this.tenantService
      .findTenantByName(name)
      .pipe(finalize(() => (this.modalBusy = false)))
      .subscribe(({success, tenantId: id, ...tenant}) => {
        if (!success) {
          this.showError();
          return;
        }

        this.setTenant({...tenant, id, isAvailable: true});
        this.isModalVisible = false;
      });
  }

  private setTenant(tenant: CurrentTenantDto | null) {
    this.sessionState.setTenant(tenant);
    this.configState.refreshAppState();
  }

  private showError() {
    this.toasterService.error('AbpUiMultiTenancy::GivenTenantIsNotAvailable', 'AbpUi::Error', {
      messageLocalizationParams: [this.name()],
    });
  }

}


