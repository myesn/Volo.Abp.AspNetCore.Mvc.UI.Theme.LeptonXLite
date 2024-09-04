import { APP_INITIALIZER } from '@angular/core';
import {
  createStyleFactory,
  LPX_LAYOUT_STYLE_FINAL,
  LpxStyleFactory,
} from '@volo/ngx-lepton-x.core';
import { LPX_SIDE_MENU_LAYOUT_STYLE_TOKEN } from '../tokens';

export const layoutBundleName = 'layout-bundle';

export const getSideMenuLayoutStylesProvider = (
  styleFactory?: LpxStyleFactory
) => [
  {
    provide: LPX_SIDE_MENU_LAYOUT_STYLE_TOKEN,
    useFactory: () => {
      return [
        {
          bundleName: layoutBundleName,
        },
      ];
    },
  },
  {
    provide: APP_INITIALIZER,
    deps: [LPX_SIDE_MENU_LAYOUT_STYLE_TOKEN],
    useValue: () => null,
    multi: true,
  },
  {
    provide: LPX_LAYOUT_STYLE_FINAL,
    deps: [LPX_SIDE_MENU_LAYOUT_STYLE_TOKEN],
    useFactory: createStyleFactory(styleFactory),
  },
];
