window.addEventListener('D0MContentLoaded'), () => {
    const title = Array.from(document.querySelectorAll(".title"));
    const playerDisplay = document.querySelector('.display-player');
    const resetButton = document.querySelector('#reset');
    const announcer = document.querySelector('.announcer');

    let board = [",",",",",",",",","]
    let currentPlayer = 'X';
    let isGameActive = true;

    const PLAYERX_WON = "PLAYERX_WON"
    const PLAYER0_WON = "PLAYERO_WON"
    const TIE = "TIE"

    resetButton.addEventListener('click', resetBoard);
}

const winningConditions = [
    [0,1,2],
    [3,4,5],
    [6,7,8],
    [0,3,6],
    [1,4,7],
    [2,5,8],
    [0,4,8]
    [2,4,6]
];
function handleResultValidation() {
    let roundWon = false;
    for (let i=0; i <= 7; i++) {
        
    }
}
