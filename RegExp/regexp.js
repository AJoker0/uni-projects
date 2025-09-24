/*const text = 'Hello Mike. Here is my phone number +38 (098) 330-00-03, my wife phone number 068-339-09-09 and 920462 my sun number 0683390791. Please use same country code +38 to have opportunity to call me';
const regexp = /\+?\d{1,3}?[\s.-]?(?:\(\d{1,4}\)|\d{1,4})?[\s.-]?\d(?:[\s.-]?\d){4,12}\b/g;
console.log(text.match(regexp));*/


/*function isValidPhoneNumber(phoneNumber) {
   const regexp = /^(?:\+\d{1,3}\s*)?(?:\(\d{3}\)|\d{3})(?:[\s.-]?\d{3}){2}/;
    return regexp.test(phoneNumber);
}

console.log(isValidPhoneNumber("(123) 456-7890"));  // true
console.log(isValidPhoneNumber("123-456-7890"));    // true
console.log(isValidPhoneNumber("123.456.7890"));    // true
console.log(isValidPhoneNumber("1234567890"));      // true
console.log(isValidPhoneNumber("+31636363634"));    // true
console.log(isValidPhoneNumber("123-45-6789"));     // false
console.log(isValidPhoneNumber("(123 456-7890"));   // false
console.log(isValidPhoneNumber("12345678"));        // false*/


const freshCourses = {usd: 37.44, eur: 39.905}

const data = `
- 02.10 Эдик 23524 грн
- 03.10 Саша 17328,грн
- 04.10 Денис 21570 грн
- 10.10 Данил 9200 грн
- 11.10 Саша 31050 грн
- 13.10 Денис 20264 грн
- 18.10 Данил 17250 грн
- 03.10 Илья 315$
- 04.10 Денис 277 €
- 06.10 Денис 503$
- 11.10 Денис 525€
- 23.10 Илья 650 $
- 31.10 Денис 596-$
- 31.10 Тимур 2350$
- 04.10 Федя 360€
- 17.10 Федя 720€
- 24.10 Федя 360€
- 04.10 Виталик 52000 грн
- 10.10 Виталик 54500 грн
- 10.10 Виталик 48700 грн 
- 20.10 Виталик 52200 грн
- 06.10 Максим 83472 грн
- 10.10 Федя 54690 грн
- 10.10 Саша 91000 грн
- 16.10 Илья 108800 грн
- 17.10 Игорь 72000 грн
- 26.10 Федя 52200 грн
`;

function groupAmountOfGrivnasByDate(str, freshCourses) {
    
    const lines = str.trim().split("\n");
    const result = {};
    let total = 0;
    
    for (let line of lines) {
        const match = line.match(/(\d{2}\.\d{2})\s+\S+\s+(\d+(?:[.,]\d+)?)(?:\s*[-,]?(грн|€|\$))/);

        if (!match) continue;
        
        let [, date, amount, currency] = match;
        amount = parseFloat(amount.replace(",","."));
        let amountInGrivnas = 0;
        if (currency === "грн") {_
            amountInGrivnas = amount;
        } else if (currency === "$") {
            amountInGrivnas = amount * freshCourses.usd;
        } else if (currency === "€") {
            amountInGrivnas = amount * freshCourses.eur;
        }

        if (!result[date]) result[date] = 0;
        result[date] += amountInGrivnas;
        total += amountInGrivnas;
    }
        
    
    return [result, total];
}

console.log(groupAmountOfGrivnasByDate(data, freshCourses));


[
  {
    '26.10': 52200,
    '17.10': 100731.6,
    '16.10': 108800,
    '10.10': 258090,
    '06.10': 102304.32,
    '20.10': 52200,
    '04.10': 98989.485,
    '24.10': 14365.800000000001,
    '31.10': 110298.23999999999,
    '23.10': 24336,
    '11.10': 52000.125,
    '03.10': 29121.6,
    '18.10': 17250,
    '13.10': 20264,
    '02.10': 23524
  },
  1064475.17
]

