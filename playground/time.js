var moment = require('moment');


//date.add(1, 'year');
var createdAt = 1234;
var date = moment(createdAt);
//console.log(date.format('MMM Do, YYYY'));
console.log(date.format('h:mm a'));
