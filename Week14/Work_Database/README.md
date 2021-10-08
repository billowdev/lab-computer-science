# Simple Access Db

Database plan: 
db_fruit
	tb_fruit
		ID (3)
		Name varchar (30)
		Quantity int (1000)
		Price int(10000)
		Date (date/time)


1.	SELECT * FROM tb_fruit;

2.	INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N003", "ละมุด", 40, 25, #6-7-2021# );

3.	INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N004", "ลำไย", 100, 4, #6-9-2021# );

4.	INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N004", "ลำไย", 100, 4, #6-9-2021# );

5.	INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N006", "ส้มเขียวหวาน สายน้ำผึ้ง เบอร์ 5", 120, 65, #25-9-2021# ) ;


6.	 UPDATE tb_fruit SET Quantity = 200, Price = 30 WHERE Name LIKE "แอปเปิ้ล";

7.	UPDATE tb_fruit SET Quantity = 500, Price = 3 WHERE ID = "N004";

8. UPDATE tb_fruit SET Quantity = 400, Price = 42 WHERE Quantity = 170;

9.	INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N007", "ส้มเขียวหวาน สายน้ำผึ้ง เบอร์ 6", 100, 75, #25-9-2021# ) ;

10.	 UPDATE tb_fruit SET st_date = #10/1/2021# WHERE ID = "N007";

11.	INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N008", "ส้มโอ ขาวน้ำผึ้ง - เล็ก", 50, 40, #25-9-2021# );

12.	UPDATE tb_fruit SET st_date = #10/2/2021#, Quantity = 400, Price=42 WHERE ID = "N008";


13. INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N009", "ลำไย", 50, 4, #3-10-2021# );
- INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N010", "ส้มโอ ขาวน้ำผึ้ง - เล็ก", 20, 40, #3-10-2021# );
- INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N011", "ส้มเขียวหวาน สายน้ำผึ้ง เบอร์ 5", 60, 65, #3-10-2021#  );
- INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N012", "ส้มเขียวหวาน สายน้ำผึ้ง เบอร์ 6", 600, 75, #3-10-2021# ) ;


14.	UPDATE tb_fruit SET st_date = #10/3/2021# WHERE st_date LIKE #3-10-2021#

