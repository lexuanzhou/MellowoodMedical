import { Component, Injector, OnInit, ViewChild } from '@angular/core';
import { CMSServiceProxy, CMScontentDto } from '../../shared/service-proxies/service-proxies';
import { ActivatedRoute, Params } from '@angular/router';
import { AppComponentBase } from '../../shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AllCmsComponent } from './allcms';

@Component({
    templateUrl: './cmscontent.component.html',
    animations: [appModuleAnimation()]
})

export class CMSContentComponent extends AppComponentBase implements OnInit {

    @ViewChild('allCmsModal') createEventModal: AllCmsComponent;

    cms: CMScontentDto = new CMScontentDto();
    pageId: number;

    constructor(
        injector: Injector,
        private _cmsService: CMSServiceProxy,
        private _activatedRoute: ActivatedRoute
    ) {
        super(injector);
    }

    ngOnInit(): void {
        this._activatedRoute.params.subscribe((params: Params) => {
            this.pageId = 1;
            this.loadCMS();
        });
    }
    
    loadCMS() {
        this._cmsService.getCMSContent(this.pageId)
            .subscribe((result: CMScontentDto) => {
                this.cms = result;
            });
    }
}
