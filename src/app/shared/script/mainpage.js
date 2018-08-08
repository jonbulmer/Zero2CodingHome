$('#nav-toggle').click(function () {
    $('.menu').toggleClass('smallMenu');
    $('.menufloat').toggleClass('menufloathide');
    $('.fa').toggleClass('fa-rotate-90');
});

$('.ReadIt').click(function() {
var Soundfile = $(this).attr('id')
$('#jp_container_l' + Soundfile).removeClass('clear');
$('#' + Soundfile + '').jPlayer({
  ready: function(event) {
  $(this).jPlayer('setMedia', {
      mp3: 'http://s375360152.websitehome.co.uk/Talk/lesson1/l' + Soundfile + '.mp3'
   });
    },
    swfPath: 'http://jplayer.org/latest/js',
    cssSelectorAncestor: '#jp_container_l' + Soundfile,
    supplied: 'mp3'
});


});   

$('.ProjectDownLoad').click(function(e) {
console.log($(this).attr('id'));   
e.preventDefault();  //stop the browser from following
window.location.href = 'http://s375360152.websitehome.co.uk/' + $(this).attr('id') + '.sb';
});   

$('#stagedemo').mousemove(function(e){
    var x = (e.pageX- this.offsetLeft) -240;
    var y = ((e.pageY - this.offsetTop) * -1) + 180;
    $('#stagexy').html("X: " + x + " Y: " + y); 
}); 

$('.btnShowNext').click(function() {
$('#' + $(this).attr('id').replace('show','')).removeClass('clear');
});   

$( ':radio').change(function() {
$('#' + $(this).attr('id').replace('show','')).removeClass('clear');
});   
  
$('#btnCalc').click(function () {
//$('#S' + 2 ).removeClass("Bblank");
if(binaryArray.length == 13 ){
 binaryArray = ''; 
}             
if(binaryArray.length == 0){
  var  res = parseInt($('#calc1').val()) + parseInt($('#calc2').val());
  setupbinary($('#calc1').val());
  //setupbinary($('#calc2').val());
  //setupbinary(res); 
  console.log(binaryArray);
}
else{
   console.log(binaryArray.length);
}

//ProgressThough($('#calc1').val(),'F');
});

}   
       
function setupbinary(passnumber){
var j;
for(var i=4;i>0;i--){
  switch(i){
      case 4:
        console.log(i);
        binaryArray += ((passnumber < 8) ? '0' : '1');
        j = ((passnumber < 8) ? '0' : '1');
       console.log('in' + j); 
       setCell(8,j);
        if (passnumber > 7){passnumber -= 8;} 
        break;
    case 3: 
        binaryArray += ((passnumber < 4) ? '0' : '1');
        if (passnumber > 3){passnumber -= 4;}
        j = ((passnumber < 4) ? '0' : '1');
        setCell(4,j);  
        break;
    case 2: 
        binaryArray += ((passnumber < 2) ? '0' : '1');
        if (passnumber > 1){passnumber -= 2;}
        j = ((passnumber < 2) ? '0' : '1');
        setCell(2,j);  
        break;
    case 1:      
        binaryArray += ((passnumber < 1) ? '0' : '1');
        if (passnumber > 0){passnumber -= 1;}
        j = ((passnumber < 1) ? '0' : '1');
        setCell(1,j); 
    break;
  }
  console.log(i + ':' + passnumber);  
}
}

function setCell(Cell,passbol) {
console.log('bin' + passbol ); 
if($('#F' + Cell ).hasClass("Bblank")){
 
  $('#F' + Cell ).removeClass("Bblank");
    
  $('#F' + Cell ).addClass('"B' + passbol + '"');
    console.log('bin3'); 
}
else{
 console.log('bin1'); 
  $('#S' + Cell ).removeClass("Bblank");
  $('#S' + Cell ).addClass('B' + passbol);
}   
}