Feature: Скласти графік 
	As a Admin
	In order to отримати список точок
	I want to складання графіку відвідування точок.
  
Scenario 1: Вибрані точки вільні
  Given Admin отримав список точок
    And точки з даного списку вільні
    And точки не більше 5-ти
    And профіль музиканта верифікований
   When Admin формує остаточний графік
    And графік походжений з музикант
   Then надсилаємо остаточний графік на профіль музиканта
    And організовуємо відвідування точок
    And вносимо дані про відвідуванняу в систему
   
Scenario 2: Деякі точки зайнятті 
  Given Адмін отримав список точок
    And деякі майстерні зайнятті
    And точок не більше 5-ти
    And профіль музиканта верифікований
   When Admin формує остаточний графік 
    And Admin видаляє зайнятті точки
    And Скульптору запропоновано альтернативу
    And графік походжений з музиканта
   Then надсилаємо остаточний графік на профіль музиканта
    And організовуємо відвідування майстерень
    And вносимо дані про відвідуванняу в систему
