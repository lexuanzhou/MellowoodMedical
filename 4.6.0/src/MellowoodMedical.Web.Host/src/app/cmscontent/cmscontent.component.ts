import { Component, Injector } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { CMSContentProxy } from '../../shared/service-proxies/service-proxies';

@Component({
    templateUrl: './cmscontent.component.html'
})

export class CMSContentComponent extends AppComponentBase {
    constructor(
        injector: Injector,
        private _cmsService: CMSServiceProxy
    ) {
        super(injector);
    }

    loadCMS() {
        this._cmsService.getListAsync()
            .subscribe((result.ListResultDtoofCMSListDto) => {
                this.cms = result.items;
            });
    }
}
