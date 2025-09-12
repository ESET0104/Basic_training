use society

select * from users
select * from orders
select * from books

-- Task1: Top N books per user
select * from (
select b.users_id, c.names, a.title,
ROW_NUMBER() over(partition by b.users_id order by a.price desc) as expense,
rank() over(partition by b.users_id order by a.price desc) as expense_rank,
dense_rank() over(partition by b.users_id order by price desc) as d_rank
from books a inner join orders b on a.product_id = b.product_id
inner join users c on b.users_id = c.users_id
) as rankedbooks
where expense <= 2 order by users_id, expense

-- Task2: Ranking users by total spending
select b.users_id, sum(price) as total,
rank() over(order by sum(price) desc) as expense_rank,
dense_rank() over(order by sum(price) desc) as d_rank
from books a inner join orders b on a.product_id = b.product_id
inner join users c on b.users_id = c.users_id group by b.users_id