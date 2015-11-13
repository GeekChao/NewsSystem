UPDATE News SET news_title = 'Mingchao Zou'
WHERE news_id = 1;

UPDATE Comment SET thumb_num = thumb_num + 1
WHERE com_news_id = 1;