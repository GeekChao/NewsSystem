SELECT * FROM News;
SELECT * FROM Comment;

SELECT * FROM News WHERE news_id = 1;

SELECT news_title, news_date FROM News 
INNER JOIN Category ON cate_id = news_cate_id
WHERE cate_name = 'Activity';

SELECT * FROM News WHERE news_text LIKE '%DIWALI%';

SELECT * FROM News 
INNER JOIN Comment ON com_news_id = news_id
INNER JOIN Category ON cate_id = news_cate_id;


SELECT * FROM News
INNER JOIN Comment ON com_news_id = news_id
INNER JOIN Category C1 ON cate_id = news_cate_id 
WHERE cate_name = 'Activity'
ORDER BY thumb_num DESC
LIMIT 1;

SELECT * FROM News INNER JOIN Comment ON com_news_id = news_id INNER JOIN Category C1 ON cate_id = news_cate_id WHERE cate_name = 'Activity' ORDER BY thumb_num DESC LIMIT 1;
