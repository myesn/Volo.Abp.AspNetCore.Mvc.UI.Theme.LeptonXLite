import { Injector, TemplateRef, Type } from '@angular/core';
import { Observable } from 'rxjs';

export interface Badge {
  count?: number | Observable<number>;
  color?: string;
  icon?: string;
}

export interface ToolbarItem {
  id?: string | number;
  name?: string;
  description?: string;
  icon?: string;
  badge?: Badge;
  component?: Type<any>;
  html?: string;
  template?: TemplateRef<any>;
  action?: () => void;
  order?: number;
  requiredPolicy?: string;
  visible?: NavBarPropPredicate<ToolbarItem>;
  additional?: { [key: string]: any };
}


type NavBarPropPredicate<T> = (
  prop?: T,
  injector?: Injector
) => boolean | Promise<boolean> | Observable<boolean>;