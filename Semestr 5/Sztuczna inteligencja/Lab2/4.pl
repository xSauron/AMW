max([],0).
max([G|O],Max):-   
    max(O,OMax),   
    G>OMax,   
    Max is G. 
max([G|O],Max):-   
    max(O,OMax),   
    G=<OMax,   
    Max is OMax.  

min([],99). 
min([G|O],Min):-   
    min(O,OMin),   
    G<OMin,   
    Min is G. 
min([G|O],Min):-   
    min(O,OMin),   
    G>=OMin,   
    Min is OMin.