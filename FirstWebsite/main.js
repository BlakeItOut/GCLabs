window.onload = function() {
    document.getElementById('person').onclick = function() {
        setPersonUrl();
    };
    document.getElementById('animal').onclick = function() {
        setAnimalUrl();
    };
    document.getElementById('animalPerson').onclick = function() {
        setPersonUrl();
        setAnimalUrl();
    };
    document.getElementById('clicker').onclick = function() {
        setPersonUrl();
        setAnimalUrl();
        setBackgroundUrl();        
    };
};

function setPersonUrl(){
    const personURL = 'https://placeimg.com/200/200/people?' + new Date().getTime();
    document.getElementById('person').src = personURL;
    document.getElementById('personAnimal').src = personURL;
}

function setAnimalUrl(){
    const animalURL = 'https://placeimg.com/200/200/animals?' + new Date().getTime();
    document.getElementById('animal').src = animalURL;
    document.getElementById('animalPerson').src = animalURL;
}

function setBackgroundUrl(){
    const natureURL = 'url(https://placeimg.com/1550/730/nature?' + new Date().getTime() + ')';
    $('body').css('background-image', natureURL);
}