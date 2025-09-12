use society

select * from books a full outer join orders b on a.product_id = b.product_id full outer join users c on b.users_id = c.users_id

select * from orders a left join books b on a.product_id = b.product_id

select a.names, c.title, c.price from users a inner join orders b on a.users_id = b.users_id 
inner join books c on b.product_id = c.product_id
where c.title in ('bhagavadgita', 'how to quit smoking', 'how to read a book')

select a.names, c.title, c.price from users a inner join orders b on a.users_id = b.users_id 
inner join books c on b.product_id = c.product_id