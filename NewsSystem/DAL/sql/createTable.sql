CREATE DATABASE IF NOT EXISTS NewsSystem;

USE NewsSystem;

DROP TABLE IF EXISTS Category, News, Comment;

CREATE TABLE Category(
	cate_id SMALLINT UNSIGNED NOT NULL AUTO_INCREMENT,
	cate_name ENUM('Activity', 'Academic', 'Else') NOT NULL,
	PRIMARY KEY(cate_id)
);

CREATE TABLE News(
	news_id SMALLINT UNSIGNED NOT NULL AUTO_INCREMENT,
	news_title VARCHAR(100),
	news_date DATE,
	news_text TEXT,
	news_img_url VARCHAR(100),
	news_cate_id SMALLINT UNSIGNED NOT NULL,
	FOREIGN KEY(news_cate_id) 
		REFERENCES Category(cate_id),
	PRIMARY KEY(news_id)
);

CREATE TABLE Comment(
	com_id SMALLINT UNSIGNED NOT NULL AUTO_INCREMENT,
	content TEXT,
	thumb_num INT,
	com_date DATE,
	com_news_id SMALLINT UNSIGNED NOT NULL,
	FOREIGN KEY(com_news_id) 
		REFERENCES News(news_id),
	PRIMARY key(com_id)
);

INSERT INTO Category VALUES(1, 'Activity'), (2, 'Academic'), (3, 'Else');
