

/*
const input = [
[33,100,110],[97,115,117],[111,104,84],[110,101,84],[32,111,116],[32,101,109],[111,99,108],[101,87]
];

function decryptMessage(data) {
// your code here
let result = "";
for (let i=0; i < data.length; i++) {
    for (let j = 0; j < data[i].length; j++) {
        result += String.fromCharCode(data[i][j]);
    }
    if ( i < data.length -1 )
} 
}

console.log(
decryptMessage(input),
);*/




const input = [
    [33, 100, 110], [97, 115, 117], [111, 104, 84], [110, 101, 84], [32, 111, 116], [32, 101, 109], [111, 99, 108], [101, 87]
];

function decryptMessage(data) {
    return data.map(word => word.map(num => String.fromCharCode(num)).join('')).join('');
}

console.log(
    decryptMessage(input),
);
