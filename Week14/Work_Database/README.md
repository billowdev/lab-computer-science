# Simple Access Db
# learning site - https://www.w3schools.com/sql/default.asp

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

Database Design :
<img align="center" width="500" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/db_design.png"/>

Initial Data :
<img align="center" width="500" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/db_fruit.png"/>

1.	SELECT
<pre>
SELECT * FROM tb_fruit;
</pre>
<img align="center" width="500" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/01-select-a.png"/>

2. INSERT
<pre>
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N003", "ละมุด", 40, 25, #6-7-2021# );
</pre>
<img align="center" width="500" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/02-insert-after.png"/>

3.	INSERT 
<pre>
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N004", "ลำไย", 100, 4, #6-9-2021# ); 
</pre>
<img align="center" width="500" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/03-insert-after.png"/>

4.	INSERT 
<pre>
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N004", "ลำไย", 100, 4, #6-9-2021# ); 
</pre>
<img align="center" width="500" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/04-insert-after.png"/>

5.	INSERT 
<pre>
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N006", "ส้มเขียวหวาน สายน้ำผึ้ง เบอร์ 5", 120, 65, #25-9-2021# ); 
</pre>
<img align="center" width="500" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/05-insert-after.png"/>


6.	UPDATE 
<pre>
UPDATE tb_fruit SET Quantity = 200, Price = 30 WHERE Name LIKE "แอปเปิ้ล"; 
</pre>
<img align="center" width="500" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/06-update-after.png"/>

7.	UPDATE 
<pre>
UPDATE tb_fruit SET Quantity = 500, Price = 3 WHERE ID = "N004"; 
</pre>
<img align="center" width="500" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/07-update-after.png"/>

8. UPDATE 
<pre>
UPDATE tb_fruit SET Quantity = 400, Price = 42 WHERE Quantity = 170; 
</pre>
<img align="center" width="500" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/08-update-after.png"/>

9.	INSERT 
<pre>
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N007", "ส้มเขียวหวาน สายน้ำผึ้ง เบอร์ 6", 100, 75, #25-9-2021# ); 
</pre>
<img align="center" width="500" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/09-insert-after.png"/>

10.	UPDATE 
<pre>
UPDATE tb_fruit SET st_date = #10/1/2021# WHERE ID = "N007"; 
</pre>
<img align="center" width="500" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/10-update-after.png"/>

11.	INSERT 
<pre>
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N008", "ส้มโอ ขาวน้ำผึ้ง - เล็ก", 50, 40, #25-9-2021# ); 
</pre>
<img align="center" width="500" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/11-insert-after.png"/>


12.	UPDATE 
<pre>
UPDATE tb_fruit SET st_date = #10/2/2021#, Quantity = 400, Price=42 WHERE ID = "N008"; 
</pre>
<img align="center" width="500" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/12-update-after.png"/>


13.  INSERT

<pre>
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N009", "ลำไย", 50, 4, #3-10-2021# );
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N010", "ส้มโอ ขาวน้ำผึ้ง - เล็ก", 20, 40, #3-10-2021# );
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N011", "ส้มเขียวหวาน สายน้ำผึ้ง เบอร์ 5", 60, 65, #3-10-2021#  );
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N012", "ส้มเขียวหวาน สายน้ำผึ้ง เบอร์ 6", 600, 75, #3-10-2021# ) ;
</pre>
<img align="center" width="500" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/13-insert-after.png"/>


14.	UPDATE 
<pre>
UPDATE tb_fruit SET st_date = #10/3/2021# WHERE st_date LIKE #3-10-2021# 
</pre>
<img align="center" width="500" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/14-update-after.png"/>

15. SELECT
<pre>
SELECT * FROM tb_fruit WHERE Price = 42;
</pre>
<img align="center" width="500" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/15-select-after.png"/>

16. INSERT
<pre>
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N013", "กระท้อนทับทิม – เบอร์กลาง", 77, 18, #10-3-2021# );
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N014", "ขนุนทองประเสริฐ", 220, 15, #10-3-2021# );
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N015", "ทุเรียนหมอนทอง – เบอร์เล็ก", 531, 130, #10-4-2021# );
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N016", "ทุเรียนหมอนทอง – เบอร์กลาง", 110, 150, #10-5-2021# );
INSERT INTO tb_fruit (ID, Name, Quantity, Price, st_date) VALUES ( "N017", "ทุเรียนหมอนทอง – เบอร์ใหญ่", 70, 180, #10-6-2021# );
</pre>
<img align="center" width="500" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/16-insert-after.png"/>

17. SELECT
<pre>
SELECT Name FROM tb_fruit;
</pre>
<img align="center" width="500" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/17-select-after.png"/>

18. SELECT
<pre>
SELECT Name, Price FROM tb_fruit;
SELECT Name, Quantity, Price FROM tb_fruit;
</pre>
<img align="center" width="500" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/17-select-after.png"/>
<img align="center" width="500" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/18-select-after-2.png"/>

19. DELETE
<pre>
DELETE FROM tb_fruit WHERE ID="N004";
<pre>
<img align="center" width="650" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/19-delete-before.png"/>
- before refresh
<img align="center" width="650" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/19-delete-pre-after.png"/>
- refresh
<img align="center" width="650" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/19-delete-refresh-after.png"/>

20. DELETE
<pre>
DELETE FROM tb_fruit WHERE st_date=#10-7-2021#;
</pre>
- before refresh
<img align="center" width="650" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/20-delete-pre-after.png"/>
- refresh
<img align="center" width="650" alt="PNG" src="https://raw.githubusercontent.com/lacakp/Computer-Science/Advance-Programming/Week14/Work_Database/snapshot/20-delete-refresh-after.png"/>

