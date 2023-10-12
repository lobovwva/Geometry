# Geometry
Тестовое задание (.net core) для MindBox

## Задача
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
<ul>
<li>Юнит-тесты
<li>Легкость добавления других фигур
<li>Вычисление площади фигуры без знания типа фигуры в compile-time
<li>Проверку на то, является ли треугольник прямоугольным
</ul>

## Unit-тесты
Код тестов лежит в директории <em>/GeometryTests </em>

## Sql.DataFrame

<b>Задача: </b>
<br>В датафреймах (pyspark.sql.DataFrame) заданы продукты, категории и связь между ними. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите метод с помощью PySpark, который вернет все продукты с их категориями (датафрейм с набором всех пар «Имя продукта – Имя категории»). В результирующем датафрейме должны также присутствовать продукты, у которых нет категорий.</br>

<b>Решение:</b>

<br>from pyspark.sql import SparkSession</br>
<br>spark = SparkSession.builder.getOrCreate()</br>
<br>products_data = [("product1", "category1"), ("product2", "category2"), ("product3", "category1")]</br>
<br>categories_data = [("category1",), ("category2",), ("category3",)]</br>
<br>products_df = spark.createDataFrame(products_data, ["product_name", "category_name"])</br>
<br>categories_df = spark.createDataFrame(categories_data, ["category_name"])</br>
<br>result_df = products_df.join(categories_df, "category_name", "left")</br>
<br>result_df.show()</br>

## SQL запрос

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

<b>Ответ:</b>
<br>Select ProductName, CategoryName From 
<br>(products LEFT JOIN products_categories ON products.ProductID = products_categories.ProductID 
<br>LEFT JOIN categories ON products_categories.CategoryID = categories.CategoryID)
