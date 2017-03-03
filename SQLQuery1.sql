select * from Customer c join [Order] o
on o.CustomerId = c.Id
order by CompanyName