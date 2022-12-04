drop database if exists students;
create database students;
use students;

create table customer(customerId int auto_increment,
						customerName varchar(80),
                        student_number varchar(14),
						primary key(customerId)
                        );

create table products(productId int  auto_increment,
						product_name varchar(45),
                        product_code numeric(8),
                        marked_price int,
						primary key(productId)
                        );
                        
create table orders(orderId int auto_increment,
					customerId int references customer(customerId),
					product_Id int references products(productId),
                    customer_name varchar(45),
                    orderDate varchar(45),
                    deliveryDate varchar(45),
                    
					primary key(orderId)
                    );
                    
-- create table order_details(productId int auto_increment,
-- 							orderId int references orders(orderId),
--                             quantity numeric(10),
--                             unit_cost int,
--                             total_cost int,
-- 							primary key(productId)
--                             );




insert into customer(customerId, customerName, student_number ) values (1, 'MWESIGWA CHRISTOMER', '2001600023'),
														(2, 'OONYU DEOGRACIOUS', '2001600014'),
                                                        (3, 'ORIOKOT MARK', '2001600017' ),
                                                        (4, 'APOLOT VICTORIA HOPE', '2001600022')
