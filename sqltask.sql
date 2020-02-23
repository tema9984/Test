SELECT Prod.name, Cat.name 
FROM Prod LEFT JOIN ProdCat
ON ProdCat.ProdID= Prod.ID LEFT JOIN Cat
ON ProdCat.CatID = Cat.ID
