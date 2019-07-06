import {Component,OnInit} from '@angular/core' 
import {AppService} from './ServiceApp.service'
import {Observable} from 'rxjs/Observable';
import {ServiceApp} from './ServiceApp';

@Component({
    selector : 'Serviceapp',
    templateUrl:'./ServiceApp.component.html',
    providers:[AppService]
})

export class ServiceAppComponent implements OnInit{   
    app: ServiceApp[];
    constructor(private service: AppService){   
    }

    ngOnInit():void{
       this.service.getService().subscribe(result=> {
          this.app = result
        });
    }
}