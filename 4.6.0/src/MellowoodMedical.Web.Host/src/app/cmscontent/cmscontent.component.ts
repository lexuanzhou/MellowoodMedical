import { Component, Injector } from '@angular/core';
import { CMSServiceProxy, CMScontentDto, ListResultDtoOfCMSListDto } from '../../shared/service-proxies/service-proxies';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from "shared/paged-listing-component-base";

@Component({
    templateUrl: './cmscontent.component.html',
    animations: [appModuleAnimation()]
})

export class CMSContentComponent extends PagedListingComponentBase<CMScontentDto> {
    

    cms: CMScontentDto[] = [];

    constructor(
        injector: Injector,
        private _cmsService: CMSServiceProxy
    ) {
        super(injector);
    }

    protected list(request: PagedRequestDto, pageNumber: number, finishedCallback: Function): void {
        throw new Error("Method not implemented.");
    }
    protected delete(entity: CMScontentDto): void {
        throw new Error("Method not implemented.");
    }

    loadCMS() {
        this._cmsService.getListAsync()
            .subscribe((result: ListResultDtoOfCMSListDto) => {
                this.cms = result.items;
            });
    }
}
