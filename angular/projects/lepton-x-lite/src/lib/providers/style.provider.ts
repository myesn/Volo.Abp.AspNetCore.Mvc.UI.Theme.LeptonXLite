import { APP_INITIALIZER } from '@angular/core';
import {
  createStyleFactory,
  LPX_INITIAL_STYLES,
  LPX_LAYOUT_STYLE_FINAL,
  LPX_STYLE_FINAL,
  LpxStyleFactory,
  LpxStyles,
} from '@volo/ngx-lepton-x.core';
import { LPX_LITE_STYLE_TOKEN } from '../tokens';

export const getLpxLiteStyleProviders = (styleFactory?: LpxStyleFactory) => [
  {
    provide: APP_INITIALIZER,
    deps: [LPX_LITE_STYLE_TOKEN],
    multi: true,
    useValue: () => null,
  },
  {
    provide: LPX_LITE_STYLE_TOKEN,
    deps: [LPX_INITIAL_STYLES, LPX_LAYOUT_STYLE_FINAL],
    useFactory: mergeStyles,
  },
  {
    provide: LPX_STYLE_FINAL,
    deps: [LPX_LITE_STYLE_TOKEN],
    useFactory: createStyleFactory(styleFactory),
  },
];

export function mergeStyles(styleList: LpxStyles, layoutStyles: LpxStyles) {
  styleList.push({
    bundleName: 'bootstrap-dim',
  });
  styleList.push({
    bundleName: 'ng-bundle',
  });
  styleList.push({
    bundleName: 'font-bundle',
  });
  return [...styleList, ...layoutStyles];
}
