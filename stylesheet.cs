* {
    padding: 0;
    margin: 0;
    font-family: Georgia, 'Times New Roman', Times, serif;
 
}
.background{
    color: plum;
    height:100vh ;
    padding-top: 1px;

}
.title{
   color: black; 
   text-align: center;
   font-size: 40px;
   margin-top: 15%;

}
.display{
    color: whitesmoke;
    font-size: 20px;
    text-align: center;
    margin-top: 1em;
    margin-bottom: 1em;
}
.hide{
    display: none;
}
.container{
    margin: 0 auto;
    display: grid;
    grid-template-columns: 33% 33% 33%;
    grid-template-rows: 33%  33%  33%;
    max-width: 330px;
    
}
.title{
    border: 1px wheat;
    min-width: 100px;
    min-height: 100px;
    display: flex;
    justify-content: center;
    align-items: center;
    font: optional;
    font-size: 50px;
    cursor: pointer;
}
.playerX{
    color: red;
}
.playerO{
    color: blue;
}
.controls{
    display: flex;
    flex-direction: row;
    justify-content: center;
    align-items: center;
    margin-top: 1em;
}
