SELECT * FROM News WHERE news_id = 1;

SELECT news_title, news_date FROM News 
INNER JOIN Category ON cate_id = news_cate_id;
WHERE cate_name = 'Activity';

SELECT * FROM News WHERE news_text LIKE '%DIWALI%';

SELECT * FROM News 
INNER JOIN Comment ON com_news_id = news_id
INNER JOIN Category ON cate_id = news_cate_id
WHERE cate_name = 'Activity' and thumb_num = MAX(thumb_num)
LIMIT 1;
