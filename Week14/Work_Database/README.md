# Simple Access Db

Database plan: 
<pre>
db_fruit
	tb_fruit
		ID (3)
		Name varchar (30)
		Quantity int (1000)
		Price int(10000)
		Date (date/time)
</pre>

1.	SELECT
<pre>
SELECT * FROM tb_fruit;
</pre>
2. INSERT
<pre>
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N003", "ละมุด", 40, 25, #6-7-2021# );
</pre> 
3.	INSERT 
<pre>
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N004", "ลำไย", 100, 4, #6-9-2021# ); 
</pre>

4.	INSERT 
<pre>
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N004", "ลำไย", 100, 4, #6-9-2021# ); 
</pre>

5.	INSERT 
<pre> 
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N006", "ส้มเขียวหวาน สายน้ำผึ้ง เบอร์ 5", 120, 65, #25-9-2021# ) ; 
</pre>


6.	UPDATE 
<pre> 
UPDATE tb_fruit SET Quantity = 200, Price = 30 WHERE Name LIKE "แอปเปิ้ล"; 
</pre>

7.	UPDATE 
<pre> 
UPDATE tb_fruit SET Quantity = 500, Price = 3 WHERE ID = "N004"; 
</pre>

8. UPDATE 
<pre> 
UPDATE tb_fruit SET Quantity = 400, Price = 42 WHERE Quantity = 170; 
</pre>

9.	INSERT 
<pre> 
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N007", "ส้มเขียวหวาน สายน้ำผึ้ง เบอร์ 6", 100, 75, #25-9-2021# ) ; 
</pre>

10.	UPDATE 
<pre> 
UPDATE tb_fruit SET st_date = #10/1/2021# WHERE ID = "N007"; 
</pre>

11.	INSERT 
<pre> 
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N008", "ส้มโอ ขาวน้ำผึ้ง - เล็ก", 50, 40, #25-9-2021# ); 
</pre>

12.	UPDATE 
<pre> 
UPDATE tb_fruit SET st_date = #10/2/2021#, Quantity = 400, Price=42 WHERE ID = "N008"; 
</pre>


13.  INSERT

<pre>
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N009", "ลำไย", 50, 4, #3-10-2021# );
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N010", "ส้มโอ ขาวน้ำผึ้ง - เล็ก", 20, 40, #3-10-2021# );
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N011", "ส้มเขียวหวาน สายน้ำผึ้ง เบอร์ 5", 60, 65, #3-10-2021#  );
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N012", "ส้มเขียวหวาน สายน้ำผึ้ง เบอร์ 6", 600, 75, #3-10-2021# ) ;
</pre>


14.	UPDATE 
<pre> 
UPDATE tb_fruit SET st_date = #10/3/2021# WHERE st_date LIKE #3-10-2021# 
</pre>

