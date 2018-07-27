import { Component, OnInit } from '@angular/core';
import * as $ from 'jquery';

@Component({
    selector: 'top-bar',
    templateUrl:'./topbar.component.html',
    styleUrls: ['./topbar.component.css']
})
export class TopbarComponent implements OnInit {
    public ngOnInit()

    {
        $(document).ready(function(){
            $("button").click(function(){
                var div = $("div");  
                div.animate({left: '100px'}, "slow");
                div.animate({fontSize: '5em'}, "slow");                
            });
        });
    }
}