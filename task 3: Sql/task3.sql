--Answer to each question will be numbered;



--1:Which customers were interested in this halloween campaign?
SELECT  customer_id FROM orders



--2:Which offers could not be converted into a sell?


SELECT * FROM sales
WHERE sales_total_price=0;




--3:Total Amount paid per customer in this halloween campaign
SELECT sales_total_price, order_Id
FROM sales
WHERE sales_total_price = ALL (SELECT order_id FROM  orders WHERE sales.order_id=orders.order_id);
