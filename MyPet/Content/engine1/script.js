// -----------------------------------------------------------------------------------
// http://wowslider.com/
// JavaScript Wow Slider is a free software that helps you easily generate delicious 
// slideshows with gorgeous transition effects, in a few clicks without writing a single line of code.
// Generated by WOW Slider 5.5
//
//***********************************************
// Obfuscated by Javascript Obfuscator
// http://javascript-source.com
//***********************************************
function ws_collage(s,I,A){var y=jQuery,C=y("ul",A),m=s.maxQuality||true,v=s.maxPreload||20,E=!s.noCanvas&&document.createElement("canvas").getContext,n=30,f=10,F=false,M=0.3,l=0.7,w=-180,b=180,e=I.length,S=[];A=A.parent();var a=y("<div>").css({position:"absolute",width:"100%",height:"100%",left:0,top:0,overflow:"hidden","z-index":8}).appendTo(A);function H(x,j,i){return parseFloat(i*(j-x)+x)}function R(W,V,N){var i=N*V.x,X=N*V.y,j=N*V.width,U=N*V.height;if(E){W.save();W.translate(i+0.5*j,X+0.5*U);W.rotate(V.angle*Math.PI/180);W.scale(V.scale,V.scale);if(V.img){W.drawImage(V.img,-0.5*j,-0.5*U,j,U)}W.restore()}else{y("<img>").attr("src",V.img).css({position:"absolute",width:100*j/s.width+"%",height:100*U/s.height+"%",left:100*i/s.width+"%",top:100*X/s.height+"%"}).appendTo(W)}}function d(V,Y,U,N,W,Z){var x=S[V],X=S[Y],j=new Date;var i=setInterval(function(){var aa=(new Date-j)/s.duration;if(aa>1){aa=1}var aj=1-2*aa;if(aj<0){aj*=-1;if(aj>1){aj=1}}aj=jQuery.easing.easeInOutQuad(1,aj,0,1,1);aa=jQuery.easing.easeInOutQuad(1,aa,0,1,1);if(E){p.width=N;p.height=W;u.width=N;u.height=W;var ab=H(s.width/X.width,s.width/x.width,aa),ac=H(0.5,H(1/X.scale,1/x.scale,aa),aj),ag=H(1/X.scale,1/x.scale,aa),ah=H(X.angle,x.angle,aa),ai=U*x.width,ad=U*x.height,af=U*H(X.x,x.x,aa),ae=U*H(X.y,x.y,aa);if(Q&&k){p.ctx.drawImage(k,0,0,N,W);p.ctx.save();p.ctx.translate(af+0.5*ai,ae+0.5*ad);p.ctx.rotate(-ah*Math.PI/180);p.ctx.scale(ag,ag);p.ctx.translate(-(af+0.5*ai),-(ae+0.5*ad));p.ctx.transform(ag,0,0,ag,-af*ag,-ae*ag);p.ctx.drawImage(k,-N,-W,N*4,W*4);p.ctx.restore()}p.ctx.transform(ab,0,0,ab,-af*ab,-ae*ab);p.ctx.translate(af+0.5*ai,ae+0.5*ad);p.ctx.rotate(-ah*Math.PI/180);p.ctx.scale(ac,ac);p.ctx.translate(-(af+0.5*ai),-(ae+0.5*ad));p.ctx.globalAlpha=H(0.2,1,aj);if(m){for(P in S){R(p.ctx,S[P],U)}}else{p.ctx.drawImage(L,0,0)}p.ctx.globalAlpha=1;p.ctx.globalAlpha=H(0,1,aj);R(p.ctx,x,U);p.ctx.globalAlpha=H(1,0,aa*2>1?1:aa*2);R(p.ctx,X,U);p.ctx.globalAlpha=1;u.ctx.drawImage(p,0,0)}else{var ak=H(2,N/(X.width*U),aj),af=-U*H(X.x,x.x,aa)*ak,ae=-U*H(X.y,x.y,aa)*ak,ai=N*ak,ad=W*ak;u.css({left:af,top:ae,width:ai,height:ad})}a.show();if(aa==1){clearInterval(i);Z()}},Math.ceil(1000/n))}function B(V,i,U,j,N){if(V>i||!S[V]||S[V].img){return}var x=new Image();x.onload=function(){S[V].img=x;if(U&&V!=N[0]&&V!=N[1]){R(j,S[V],1);B(V+1,i,true,j,N)}else{B(V+1,i,false)}};x.onerror=function(){if(U&&V!=N[0]&&V!=N[1]){R(j,S[V],1);B(V+1,i,true,j,N)}else{B(V+1,i,false)}};x.src=I[V].src}var r=0,q=0,t=s.width/(Math.sqrt(e)+1),z=s.height/(Math.sqrt(e)+1),c=Math.floor(s.width/t);for(P=0;P<e;P++){if(t+r>t*c){q=Math.floor(t*(P+1)/s.width)*z;r=0}S[P]={x:r,y:q,width:t,height:z,img:null};if(E){S[P].scale=H(M,l,Math.random());S[P].angle=H(w,b,Math.random())}r+=parseFloat(t)}for(var O,D,P=S.length;P;O=parseInt(Math.random()*P),D=S[--P],S[P]=S[O],S[O]=D){}if(E){var u=y("<canvas>")[0];u.ctx=u.getContext("2d");u.width=a.width();u.height=a.height();var p=y("<canvas>")[0];p.ctx=p.getContext("2d");p.width=a.width();p.height=a.height();var k=y("<canvas>")[0];k.ctx=k.getContext("2d");k.width=a.width();k.height=a.height();if(!m){var L=y("<canvas>")[0];L.ctx=L.getContext("2d");L.width=a.width();L.height=a.height()}a.append(u)}else{var u=a.clone().css({overflow:"visible"});a.css("display","none").append(u);for(P in S){S[P].img=I[P].src;R(u,S[P],1)}var h=(e%c=="undefined"?0:e%c);startRight=0,bottomAddCount=2*c-h,rightAddCount=Math.ceil(e/c)+1;for(var P=0;P<bottomAddCount;P++){R(u,{img:I[P%I.length].src,width:t,height:z,x:t*((h+P)%c),y:q+Math.floor((h+P)/c)*z},1)}for(var P=0;P<bottomAddCount;P++){R(u,{img:I[P%I.length].src,width:t,height:z,x:t*c,y:P*z},1)}}var G,Q;this.go=function(x,U){if(G){return -1}if(s.images){S[x].img=I[x]}if(window.XMLHttpRequest){var N=a.width(),j=a.height(),i=N/s.width;if(E){B(U,U,false);B(x,x,false);if(m){B(2,v+1,false)}else{L.width=N;L.height=j;B(2,v+1,true,L.ctx,[U,x])}if(!Q&&!F){rand=Math.round(H(0,e-1,Math.random()));k.width=a.width();k.height=a.height();Q=J(y(I[rand]),f,k)}}G=new d(x,U,i,N,j,function V(){C.css({left:-x+"00%"}).show();a.hide();G=0;if(!m&&E){for(i in S){S[i].img=null}}})}else{G=0;C.stop(true).animate({left:(x?-x+"00%":(/Safari/.test(navigator.userAgent)?"0%":0))},s.duration,"easeInOutExpo")}return x};function J(i,x,j){if(E){j.ctx.drawImage(i.get(0),0,0);if(!o(j.ctx,0,0,j.width,j.height,x)){j.ctx.drawImage(i.get(0),0,0)}return true}return cont}var g=[512,512,456,512,328,456,335,512,405,328,271,456,388,335,292,512,454,405,364,328,298,271,496,456,420,388,360,335,312,292,273,512,482,454,428,405,383,364,345,328,312,298,284,271,259,496,475,456,437,420,404,388,374,360,347,335,323,312,302,292,282,273,265,512,497,482,468,454,441,428,417,405,394,383,373,364,354,345,337,328,320,312,305,298,291,284,278,271,265,259,507,496,485,475,465,456,446,437,428,420,412,404,396,388,381,374,367,360,354,347,341,335,329,323,318,312,307,302,297,292,287,282,278,273,269,265,261,512,505,497,489,482,475,468,461,454,447,441,435,428,422,417,411,405,399,394,389,383,378,373,368,364,359,354,350,345,341,337,332,328,324,320,316,312,309,305,301,298,294,291,287,284,281,278,274,271,268,265,262,259,257,507,501,496,491,485,480,475,470,465,460,456,451,446,442,437,433,428,424,420,416,412,408,404,400,396,392,388,385,381,377,374,370,367,363,360,357,354,350,347,344,341,338,335,332,329,326,323,320,318,315,312,310,307,304,302,299,297,294,292,289,287,285,282,280,278,275,273,271,269,267,265,263,261,259];var K=[9,11,12,13,13,14,14,15,15,15,15,16,16,16,16,17,17,17,17,17,17,17,18,18,18,18,18,18,18,18,18,19,19,19,19,19,19,19,19,19,19,19,19,19,19,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24,24];function o(aI,ap,an,j,N,az){if(isNaN(az)||az<1){return}az|=0;var aD;try{aD=aI.getImageData(ap,an,j,N)}catch(aH){console.log("error:unable to access image data: "+aH);return false}var X=aD.data;var ax,aw,aF,aC,ae,ah,ab,V,W,am,ac,ao,ak,at,ay,af,aa,ag,ai,ar;var aG=az+az+1;var au=j<<2;var ad=j-1;var aB=N-1;var Z=az+1;var aA=Z*(Z+1)/2;var aq=new T();var al=aq;for(aF=1;aF<aG;aF++){al=al.next=new T();if(aF==Z){var Y=al}}al.next=aq;var aE=null;var av=null;ab=ah=0;var aj=g[az];var U=K[az];for(aw=0;aw<N;aw++){at=ay=af=V=W=am=0;ac=Z*(aa=X[ah]);ao=Z*(ag=X[ah+1]);ak=Z*(ai=X[ah+2]);V+=aA*aa;W+=aA*ag;am+=aA*ai;al=aq;for(aF=0;aF<Z;aF++){al.r=aa;al.g=ag;al.b=ai;al=al.next}for(aF=1;aF<Z;aF++){aC=ah+((ad<aF?ad:aF)<<2);V+=(al.r=(aa=X[aC]))*(ar=Z-aF);W+=(al.g=(ag=X[aC+1]))*ar;am+=(al.b=(ai=X[aC+2]))*ar;at+=aa;ay+=ag;af+=ai;al=al.next}aE=aq;av=Y;for(ax=0;ax<j;ax++){X[ah]=(V*aj)>>U;X[ah+1]=(W*aj)>>U;X[ah+2]=(am*aj)>>U;V-=ac;W-=ao;am-=ak;ac-=aE.r;ao-=aE.g;ak-=aE.b;aC=(ab+((aC=ax+az+1)<ad?aC:ad))<<2;at+=(aE.r=X[aC]);ay+=(aE.g=X[aC+1]);af+=(aE.b=X[aC+2]);V+=at;W+=ay;am+=af;aE=aE.next;ac+=(aa=av.r);ao+=(ag=av.g);ak+=(ai=av.b);at-=aa;ay-=ag;af-=ai;av=av.next;ah+=4}ab+=j}for(ax=0;ax<j;ax++){ay=af=at=W=am=V=0;ah=ax<<2;ac=Z*(aa=X[ah]);ao=Z*(ag=X[ah+1]);ak=Z*(ai=X[ah+2]);V+=aA*aa;W+=aA*ag;am+=aA*ai;al=aq;for(aF=0;aF<Z;aF++){al.r=aa;al.g=ag;al.b=ai;al=al.next}ae=j;for(aF=1;aF<=az;aF++){ah=(ae+ax)<<2;V+=(al.r=(aa=X[ah]))*(ar=Z-aF);W+=(al.g=(ag=X[ah+1]))*ar;am+=(al.b=(ai=X[ah+2]))*ar;at+=aa;ay+=ag;af+=ai;al=al.next;if(aF<aB){ae+=j}}ah=ax;aE=aq;av=Y;for(aw=0;aw<N;aw++){aC=ah<<2;X[aC]=(V*aj)>>U;X[aC+1]=(W*aj)>>U;X[aC+2]=(am*aj)>>U;V-=ac;W-=ao;am-=ak;ac-=aE.r;ao-=aE.g;ak-=aE.b;aC=(ax+(((aC=aw+Z)<aB?aC:aB)*j))<<2;V+=(at+=(aE.r=X[aC]));W+=(ay+=(aE.g=X[aC+1]));am+=(af+=(aE.b=X[aC+2]));aE=aE.next;ac+=(aa=av.r);ao+=(ag=av.g);ak+=(ai=av.b);at-=aa;ay-=ag;af-=ai;av=av.next;ah+=j}}aI.putImageData(aD,ap,an);return true}function T(){this.r=0;this.g=0;this.b=0;this.a=0;this.next=null}}jQuery.extend(jQuery.easing,{easeInOutQuad:function(e,f,a,h,g){if((f/=g/2)<1){return h/2*f*f+a}return -h/2*((--f)*(f-2)-1)+a}});// -----------------------------------------------------------------------------------
// http://wowslider.com/
// JavaScript Wow Slider is a free software that helps you easily generate delicious 
// slideshows with gorgeous transition effects, in a few clicks without writing a single line of code.
// Generated by WOW Slider 5.5
//
//***********************************************
// Obfuscated by Javascript Obfuscator
// http://javascript-source.com
//***********************************************
jQuery("#wowslider-container1").wowSlider({effect:"collage",prev:"",next:"",duration:20*100,delay:20*100,width:960,height:360,autoPlay:true,playPause:true,stopOnHover:false,loop:false,bullets:true,caption:true,captionEffect:"slide",controls:true,onBeforeStep:0,images:0});