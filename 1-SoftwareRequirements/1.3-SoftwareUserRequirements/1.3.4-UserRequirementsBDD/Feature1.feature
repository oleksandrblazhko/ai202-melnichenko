Feature: Авторизація на сервісі
	As a музикант 
	In order to авторизуватись на сервісі
	I want to використовувати функціонал сервісу.
  
Scenario 1: Створення нового запису
  Given музикант створює новий запис
    And його дані є актуальними 
    And його дані унікальні
   When музикант вносить особистрі дані
   Then реєструємо  музикант а на сервісі
    And спостерігаємо профіль в системі
    
Scenario 2: Авторизація за існуючим аккаунтом
  Given музикант вже має власний профіль
    And профіль є у системі
   When музикант вносить дані для авторизації 
     And дані для авторизації Скульптора коректні
   Then надаємо доступ до сервісу
    And реєструємо інформацію про поточний сеанс
