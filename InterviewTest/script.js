const str = ":apple: <@viktor> sadjhabsdj bjshdba :apple: :banana: :ananas: apple <@kate> :apple: dkjbsakjd <@kate> :grape: :apple:";

function calc() {
// return ...
const result ={};
let currentPerson = null;

const parts = str.split(/\s+/);
for(let part of parts) {
    const match = part.match(/<@(\w+)>/);
    if(match) {
        currentPerson = match[1];
        if (!result[currentPerson]) {
            result[currentPerson] = 0;
        }
    } else if (part === ":apple:" && currentPerson) {
        result[currentPerson]++;
    }
}
return result;
}

console.log(calc());

//result of calc method should be equal to
// {
//     viktor: 1,
//     kate: 2,
// }













