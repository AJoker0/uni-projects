const obj = {
viktor: ['apple', 'grape', 'orange', 'apple', 'banana'],
kate: ['grape', 'orange', 'apple', 'grape', 'banana'],
};

function calc() {
// заборонено звертатись напряму до obj.viktor або object.kate
// return ...
const result = {};

for (let user in obj) {
    result[user] = {}; 
    for (let fruit of obj[user]) {
        result[user] = {};
        for(let fruit of obj[user]) {
            result[user][fruit] = (result[user][fruit] || 0) + 1;
        }
    }
}
return result;
}

console.log(calc());
//result of calc method should be equal to
// {
//     viktor: {
//         apple: 2,
//         grape: 1,
//         orange: 1,
//         banana: 1,
//     }, 
//     kate: {
//         apple: 1,
//         grape: 2,
//         orange: 1,
//         banana: 1,
//     },
// }
