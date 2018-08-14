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
            var os = "Unknown OS";
            var dl = "Sorry can't download scratch here";
            if (navigator.appVersion.indexOf("Win") != -1) { os = "Windows"; dl = "ScratchInstaller1.4.exe"; }
            else if (navigator.appVersion.indexOf("Mac") != -1) { os = "MacOS"; dl = "MacScratch1.4.dmg"; }
            else if (navigator.appVersion.indexOf("X11") != -1) { os = "UNIX"; dl = "follow instuctions"; }
            else if (navigator.appVersion.indexOf("Linux") != -1) { os = "Linux"; dl = "follow instuctions"; }
            $('#OS').html(os);
            $('#scratchdownload').html(dl);
            ApplyBehaviour();              
        });

        function ApplyBehaviour() {
            $('.ProjectDownLoad').click(function(e) {
                console.log($(this).attr('id'));   
                e.preventDefault();  //stop the browser from following
                window.location.href = 'http://s375360152.websitehome.co.uk/' + $(this).attr('id') + '.sb';
            });            
        }
    }
}