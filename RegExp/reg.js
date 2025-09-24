/*const text = 'Hello, - World1234+';

const regexp = /(?<=[a-z])[a-z]+(?:[a-z])/i;

console.log(text.match(regexp))*/

/*const text = '<@Viktor/> @Hey team. Iwould +38 (050) 552-35-05 380505523505 like to have qwer123_aj@gmail123.service_5.online._124312312 a call with <@Megan123/> at 10:00 tomorrow!';

const regexp = /(?<=<@)\w+(?=\/)/g;

console.log(text.match(regexp));*/

/*const regexp = /[a-z0-9_]+@[a-z0-9_.]+\.[a-z]{2,12}/g;

console.log(text.match(regexp));*/

//const text = 'Order 123 was shipped on 2025-09-18.';

//const regexp = /\d+(?:-\d+)*/g;
//console.log(text.match(regexp));

/*const text = 'kebabbarak012@gmail.com'
const regexp = /^[a-zA-Z0-9._+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
console.log(text.match(regexp));*/

/*const text = '+88005553535 or you can call on this number: 0888-123-456 or also we have this one (+359 888 123 456)';
const regexp = /\+?\(?\d[\d\s()-]{4,}\d\)?/g;
console.log(text.match(regexp));
*/

/*
// reg.js
const readline = require('readline');

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

// твоя регулярка для телефонов
const phoneRe = /\+?\(?\d[\d\s()-]{4,}\d\)?/g;

rl.question('Введите текст: ', (text) => {
  const matches = Array.from(text.matchAll(phoneRe), m => m[0]);
  if (matches.length) {
    console.log('Совпадения:', matches);
  } else {
    console.log('Ничего не найдено.');
  }
  rl.close();
});

*/

/*const text = '192.168.1.1 — типичный адрес роутера в домашней сети (частный). 192.168.1.100 — пример адреса компьютера в домашней сети 10.0.0.5 — пример адреса в сети 10.0.0.0/8 (частный) 172.16.0.10 — пример адреса в диапазоне 172.16.0.0/12 (частный) 8.8.8.8 — публичный DNS-сервер Google (публичный) 93.184.216.34 — пример публичного IP (пример сайта example.com) 203.0.113.5 — адрес из тестового диапазона (TEST-NET-3), используется в документации. '

const regexp = /\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b/g;
console.log(text.match(regexp));*/

/*const text = 'apple juice, orange juice, tomato';

const regexp = /\w+(?= juice)/g;
console.log(text.match(regexp));*/

/*const text = '<p>Hello World</p> <div>Привет мир</div> <span>!!!</span>';
const regexp = /<[^>]+>/g;
console.log(text.match(regexp));*/
///////////////////////////////////////////////////////////////////////////////////////////////////////




/*const text = 'kebabbarak012@gmail.com ahalay mahalay v ZOPU ebay kinder@rambler.ru abraham.chicha@gmail.com and bla@yandex.ru';
const regexp = /\b[^\s@]+@[^\s@]+\.[^\s@]{2,}\b/gi;
console.log(text.match(regexp));*/




/*const text = 'Call +380 (67) 123-45-67 or 020-7946-0958 или 0688526585';
const regexp = /\+?\d{1,3}[\s.-]?(?:\(\d{1,4}\)|\d{1,4})[\s.-]?\d(?:[\s.-]?\d){5,12}\b/g;
console.log(text.match(regexp));*/


/*const text = 'see https://example.com or http://sub.domain.io:8080/a?b=1';
const regexp = /\bhttps?:\/\/(?:[\w-]+\.)+[\w-]{2,}(?::\d{2,5})?(?:[/?#][^\s]*)?/gi;
console.log(text.match(regexp));*/

/*const text = 'IPs: 192.168.1.1, 10.0.0.256, 8.8.8.8';
const regexp = /\b(?:(?:25[0-5]|2[0-4]\d|1?\d?\d)\.){3}(?:25[0-5]|2[0-4]\d|1?\d?\d)\b/g;
console.log(text.match(regexp));*/

/*const text = 'Dates: 2025-09-23, 2025-13-01, 1999-01-31';
const regexp = /\b\d{4}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01])\b/g;
console.log(text.match(regexp));*/

/*const text = 'Times: 23:59:59, 07:05, 24:01';
const regexp = /\b([01]\d|2[0-3]):[0-5]\d(?::[0-5]\d)?\b/g;
console.log(text.match(regexp));*/

/*const text = 'users: _bad, good_user1, A1, Mega_User_2000';
const regexp = /\b(?!_)[A-Za-z0-9_]{3,16}\b/g;
console.log(text.match(regexp));*/

/*const text = 'ok: my-new-post-1; bad: -bad--slug-';
const regexp = /\b[a-z0-9]+(?:-[a-z0-9]+)*\b/g;
console.log(text.match(regexp));*/

/*const text = 'текст #Одеса #odessa2025 #вау';
const regexp = /#[\p{L}\p{N}_]+/gu;
console.log(text.match(regexp));*/

/*const text = 'colors: #1e90ff, #ABC, rgb(12,34,56), rgba(0,0,0,0.5)';
const regexp = /#(?:[0-9A-Fa-f]{3}|[0-9A-Fa-f]{6}|[0-9A-Fa-f]{8})\b/g;
const regexp1 = /rgba?\(\s*(?:[01]?\d?\d|2[0-4]\d|25[0-5])\s*,\s*(?:[01]?\d?\d|2[0-4]\d|25[0-5])\s*,\s*(?:[01]?\d?\d|2[0-4]\d|25[0-5])(?:\s*,\s*(?:0?\.\d+|1|0))?\s*\)/g;
console.log(text.match(regexp));
console.log(text.match(regexp1));*/

/*const text = 'prices: 10, 10.00, .99, 100.5';
const regexp = /\b\d+(?:\.\d{2})?\b/g;
console.log(text.match(regexp));*/

/*const text = 'nums: -5, +3.14, .25, 10.';
const regexp = /[+-]?(?:\d+\.?\d*|\.\d+)/g;
console.log(text.match(regexp));*/

/*const text = '90210, K1A 0B1, SW1A 1AA';
const regexp = /\b(?:\d{5}(?:-\d{4})?|[A-Z]\d[A-Z]\s?\d[A-Z]\d|[A-Z]{1,2}\d[\dA-Z]?\s?\d[A-Z]{2})\b/gi;
console.log(text.match(regexp));*/

/*const text = '<b>bold</b>  <img src="x"/> <div class="a">x</div>';
const regexp = /<([A-Za-z][A-Za-z0-9:-]*)(\s+[^>]*)?>.*?<\/\1\s*>/gs;
console.log(text.match(regexp));*/

/*const text = 'This is very very good, not not bad';
const regexp = /\b(\w+)\s+\1\b/gi;
console.log(text.match(regexp));*/

/*const text = ['abc', '"a,b"', '"a ""quoted"" b"', 'a, b'];
const regexp = /^(?:"([^"]*(?:""[^"]*)*)"|[^",\r\n]*)$/;
console.log('19:', text.map(s => regexp.test(s)));
*/

/*const text = 'heyyy!!! noo---';
const regexp = /(.)\1{2,}/g;
console.log(text.match(regexp));*/

