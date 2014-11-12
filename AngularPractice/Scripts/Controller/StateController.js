/// <reference path="https://ajax.googleapis.com/ajax/libs/angularjs/1.0.8/angular.min.js" />

questApp.controller('QuestionController',
    function QuestionController($scope) {

        $scope.question = {
            text: 'Какой js-фреймворк лучше использовать?',
            author: 'Иван Иванов',
            date: '20/10/2013',
            answers:
            [{
                text: 'AngularJS!',
                author: 'Вова Сидоров',
                date: '20/10/2013',
                rate: 2
            }, {
                text: 'AngularJS лучше всех',
                author: 'Олег Кузнецов',
                date: '21/10/2013',
                rate: 3
            }, {
                text: 'фигасе квестшен',
                author: 'Неизвестный',
                date: '22/10/2013',
                rate: 0
            }]
        },

        $scope.voteUp = function (answer) {
            answer.rate++;
        };
        $scope.voteDown = function (answer) {
            answer.rate--;
        };
    });