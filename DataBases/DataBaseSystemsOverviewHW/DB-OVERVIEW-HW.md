## Database Systems - Overview
### _Homework_

#####1.  What database models do you know?
 > * __Relational Model:__
The relational model is the best known and in today’s DBMS most often implemented database model. 
    It defines a database as a collection of tables (relations) which contain all data. 
    This module deals predominantly with the relational database model and the database systems based on it.
> * __Object-oriented Model:__
Object-oriented models define a database as a collection of objects with features and methods.
    A detailed discussion of object-oriented databases follows in an advanced module.
> * __Hierarchical database Model:__
A hierarchical database model is a data model in which the data is organized into a tree-like structure.
   The data is stored as records which are connected to one another through links. 
   A record is a collection of fields, with each field containing only one value. 
   The entity type of a record defines which fields the record contains.
> * __Network database Model:__
The network model is a database model conceived as a flexible way of representing objects and their relationships. 
  Its distinguishing feature is that the schema, viewed as a graph in which object types are nodes and relationship types are arcs, is not restricted to being a hierarchy or lattice.
  
 > [_Click on this Link for more information about database models_](https://www.google.bg/search?q=database+models&oq=data&aqs=chrome.0.69i59j69i57j69i60l3j69i59.1051j0j7&sourceid=chrome&ie=UTF-8 "Title")

#####2.  Which are the main functions performed by a Relational Database Management System (RDBMS)?
> * __Security Management:__
This is one of the most important functions in the DBMS. 
  Security management sets rules that determine specific users that are allowed to access the database. 
  Users are given a username and password or sometimes through biometric authentication (such as a fingerprint or retina scan) but these types of authentication tend to be more costly. 
  This function also sets restraints on what specific data any user can see or manage.
> * __Data Storage Management:__
This particular function is used for the storage of data and any related data entry forms or screen definitions, report definitions, data validation rules, procedural code, and structures that can handle video and picture formats. 
  Users do not need to know how data is stored or manipulated. 
  Also involved with this structure is a term called performance tuning that relates to a database’s efficiency in relation to storage and access speed.
> * __Multiuser Access Control:__ 
Data integrity and data consistency are the basis of this function. 
  Multiuser access control is a very useful tool in a DBMS, it enables multiple users to access the database simultaneously without affecting the integrity of the database.
> * __Backup and Recovery Management:__
Backup and recovery is brought to mind whenever there is potential outside threats to a database. 
  For example if there is a power outage, recovery management is how long it takes to recover the database after the outage. 
  Backup management refers to the data safety and integrity.
> * __Data Integrity Management:__
The DBMS enforces these rules to reduce things such as data redundancy, which is when data is stored in more than one place unnecessarily, and maximizing data consistency, making sure database is returning correct/same answer each time for same question asked.
> * __Database Access Languages and Application Programming Interfaces:__
A query language is a nonprocedural language. 
  An example of this is SQL (structured query language). 
  SQL is the most common query language supported by the majority of DBMS vendors. 
  The use of this language makes it easy for user to specify what they want done without the headache of explaining how to specifically do it.
> * __Database Communication Interfaces:__
This refers to how a DBMS can accept different end user requests through different network environments. An example of this can be easily related to the internet.  A DBMS can provide access to the database using the Internet through Web Browsers.
#####3.  Define what is "table" in database terms.
>A table is a collection of related data held in a structured format within a database. It consists of columns, and rows.
  
>In relational databases and flat file databases, a table is a set of data elements (values) using a model of vertical columns (identifiable by name) and horizontal rows, the cell being the unit where a row and column intersect. A table has a specified number of columns, but can have any number of rows. Each row is identified by one or more values appearing in a particular column subset. The columns subset which uniquely identifies a row is called the primary key.
  
>"Table" is another term for "relation"; although there is the difference in that a table is usually a multiset (bag) of rows where a relation is a set and does not allow duplicates. Besides the actual data rows, tables generally have associated with them some metadata, such as constraints on the table or on the values within particular columns.
  
>The data in a table does not have to be physically stored in the database
#####4.  Explain the difference between a primary and a foreign key.
>A PRIMARY Key and UNIQUE Key constraints both are similar and it provide unique enforce uniqueness of the column on which they are defined.
 
 > * __Primary Key:__
 >Primary key cannot have a NULL value.
 >Each table can have only one primary key.
 >By default, Primary key is clustered index and data in the database table is physically organized in the sequence of clustered index.
 >Primary key can be related with another table's as a Foreign Key.
 >We can generated ID automatically with the help of Auto Increment field. Primary key supports Auto Increment value.
 
 > * __Unique Key:__
 >Unique Constraint may have a NULL value.
 >Each table can have more than one Unique Constraint.
 >By default, Unique key is a unique non-clustered index.
 >Unique Constraint can not be related with another table's as a Foreign Key.
 >Unique Constraint doesn't supports Auto Increment value.
 
 > * __Foreign Key:__
 >Foreign key is a field in the table that is primary key in another table.
 >Foreign key can accept multiple null value.
 >Foreign key do not automatically create an index, clustered or non-clustered. You can manually create an index on foreign key.
 >We can have more than one foreign key in a table.
 >There are actual advantages to having a foreign key be supported with a clustered index, but you get only one per table. What's the advantage? If you are selecting the parent plus all child records, you want the child records next to each other. This is easy to accomplish using a clustered index.
 
 >[_Click on this Link for more information and database Keys_](http://www.essentialsql.com/what-is-the-difference-between-a-primary-key-and-a-foreign-key/ "Title")
#####5.  Explain the different kinds of relationships between tables in relational databases.
> * __One-to-One Relationships:__
> In a one-to-one relationship, each row in one database table is linked to one and only one other row in another table. In a one-to-one relationship between Table A and Table B, each row in Table A is linked to another row in Table B. The number of rows in Table A must equal the number of rows in Table B.
  It would be apparent that one-to-one relationships are not very useful since the database designer might as well simply merge both tables into a single table. This is true in general. However, there are some situations in which the one-to-one relationship may improve performance. For example, if a database table contains a few columns of data that is frequently used and the remaining columns being infrequently used, the database designer may split the single table into 2 tables linked through a one-to-one relationship. Such a design would reduce the overhead needed to retrieve the infrequently used columns whenever query is performed on the contents of the database table.
> * __One-to-Many Relationships:__
> In a one-to-many relationship, each row in the related to table can be related to many rows in the relating table. This effectively save storage as the related record does not need to be stored multiple times in the relating table.
  For example, all the customers belonging to a business is stored in a customer table while all the customer invoices are stored in an invoice table. Each customer can have many invoices but each invoice can only be generated for a single customer.
> * __Many-to-Many Relationships:__
> In a many-to-many relationship, one or more rows in a table can be related to 0, 1 or many rows in another table. A mapping table is required in order to implement such a relationship.
  For example, all the customers belonging to a bank is stored in a customer table while all the bank's products are stored in a product table. Each customer can have many products and each product can be assigned to many customers.
  
 >[_Click on this Link for more information about relationships between tables in  Relational databases._](https://code.tutsplus.com/articles/sql-for-beginners-part-3-database-relationships--net-8561 "Title")
#####6.  When is a certain database schema normalized?
>  __Database Normalization:__
> Database normalization, or simply normalization, is the process of organizing the columns (attributes) and tables (relations) of a relational database to reduce data redundancy and improve data integrity.
  Normalization involves arranging attributes in tables based on dependencies between attributes, ensuring that the dependencies are properly enforced by database integrity constraints. Normalization is accomplished through applying some formal rules either by a process of synthesis or decomposition. Synthesis creates a normalized database design based on a known set of dependencies. Decomposition takes an existing (insufficiently normalized) database design and improves it based on the known set of dependencies.

>__What are the advantages of normalized databases?__
> *  Data integrity (because there is no redundant, neglected data).
> * Optimized queries (because normalized tables produce rapid, efficient joins).
> * Faster index creation and sorting (because the tables have fewer columns).
> * Faster UPDATE performance (because there are fewer indexes per table).
> * Improved concurrency resolution (because table locks will affect less data).

>[_Click on this Link for more information about Normalized databases_](https://msdn.microsoft.com/en-us/library/aa291817(v=vs.71).aspx "Title")
#####7.  What are database integrity constraints and when are they used?
> Constraints are the rules enforced on data columns on table. These are used to limit the type of data that can go into a table. This ensures the accuracy and reliability of the data in the database.
  Constraints could be column level or table level. Column level constraints are applied only to one column, whereas table level constraints are applied to the whole table.
  
  
>[_Click on this Link for more information about constraints_](http://www.w3schools.com/sql/sql_constraints.asp "Title")

#####8.  Point out the pros and cons of using indexes in a database.
> If there is a usable index on the table, the query performance and therefore the stored procedure performance can be improved dramatically.
 But at the same time also slows down inserts, updates and deletes because database engine does not have to write the data only, but the index, too.
 An index need space on hard disk (and much more important) in RAM. An index that can not be held in RAM is pretty useless.
 
>[_Click on this Link for more information about indices_](http://blog.copadata.at/wp/pros-and-cons-of-using-sql-server-table-indices/ "Title")

#####9.  What's the main purpose of the SQL language?
> SQL allows users to access data stored in a relational database management system. Users can create and delete databases, as well as set permissions on database tables, views and procedures. It also allows users to manipulate the data within a database.
  In SQL, there are two main sets of commands that are used to create and modify databases. These are the Data Definition Language and the Data Manipulation Language. The former contains commands used to develop and delete databases and its objects, and the latter contains commands used to insert, modify and delete data stored in a database.
  SQL language is divided into several elements: clauses, expressions, predicates, queries and statements. SQL queries are the most essential and common SQL operations. An SQL query helps users retrieve needed data from a database, and it is executed using the ‘Select’ statement.
#####10.  What are transactions used for?
> __Description with Example:__ A transaction is a unit of work that you want to treat as "a whole". It has to either happen in full, or not at all.
  A classical example is transferring money from one bank account to another. To do that you have to first withdraw the amount from the source account, and then deposit it to the destination account. The operation has to succeed in full. If you stop halfway, the money will be lost, and that is Very Bad.
  In modern databases transactions also do some other things - like ensure that you can't access data that another person has written halfway. But the basic idea is the same - transactions are there to ensure, that no matter what happens, the data you work with will be in a sensible state. They guarantee that there will NOT be a situation where money is withdrawn from one account, but not deposited to another.
  
>[_Click on this Link for more information about transactions_](https://en.wikipedia.org/wiki/Database_transaction "Title")
#####11.  What is a NoSQL database?
> A NoSQL (originally referring to "non SQL", "non relational" or "not only SQL") database provides a mechanism for storage and retrieval of data which is modeled in means other than the tabular relations used in relational databases. Such databases have existed since the late 1960s, but did not obtain the "NoSQL" moniker until a surge of popularity in the early twenty-first century, triggered by the needs of Web 2.0 companies such as Facebook, Google, and Amazon.com.
  NoSQL databases are increasingly used in big data and real-time web applications. NoSQL systems are also sometimes called "Not only SQL" to emphasize that they may support SQL-like query languages.
  Motivations for this approach include: simplicity of design, simpler "horizontal" scaling to clusters of machines (which is a problem for relational databases), and finer control over availability. The data structures used by NoSQL databases (e.g. key-value, wide column, graph, or document) are different from those used by default in relational databases, making some operations faster in NoSQL. The particular suitability of a given NoSQL database depends on the problem it must solve. Sometimes the data structures used by NoSQL databases are also viewed as "more flexible" than relational database tables.
  
>[_Click on this Link for more information NoSql Databases_](https://en.wikipedia.org/wiki/NoSQL "Title")
#####12.  Explain the classical non-relational data models.
> A non-relational database is a database that does not incorporate the table/key model that relational database management systems (RDBMS) promote.
  These kinds of databases require data manipulation techniques and processes designed to provide solutions to big data problems that big companies face. 
  The most popular emerging non-relational database is called NoSQL (Not Only SQL).
  
#####13.  Give few examples of NoSQL databases and their pros and cons.
>  __NoSql Databases__
> * MongoDB (Mature and powerful JSON-Document database)
> * CouchDB (JSON-based document database with REST API)
> * Redis (Ultra-fast in-memory data structures server)
> * Cassandra (Distributed wide-column database)

>[_Click on this Link for more NoSql Databases_](http://nosql-database.org/ "Title")

> __NoSql Databases Models__
> * Document model
> * Wide-column model
> * Object model
> * Hierarchical key-value model
> * Associative (Key-value) model

> __Pros__
> * Support CRUD operations
> * Support Indexing and querying
> * Support concurrency and transactions
> * Highly optimized for append / retrieve
> * Great performance and scalability

> __Cons__
> * Difficult administration and support
> * Less mature
> * Less support
> * Business intelligence and analytics
> * No advanced expertise


>[_Click on this Link for more information about Pros and Cons in NoSql Databases_](http://nosql-database.org/ "Title")



