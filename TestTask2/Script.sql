SELECT prod.name, cat.name FROM Products prod
    LEFT JOIN ProductCategory prodcat ON prod.id = prodcat.product_id
    LEFT JOIN Category cat ON cat.id = prodcat.category_id
ORDER BY prod.name;