if not exists (select 1 from dbo.[Perfumes])
begin
	insert into dbo.[Perfumes] 
	(Name, Designer, Perfumer, Launched, Description)
	values 
			('Gentle Fluidity Gold',
			'Maison Francis Kurkdjian',
			'Francis Kurkdjian',
			'2019',
			'Gentle Fluidity Gold by Maison Francis Kurkdjian 
			is a Amber Vanilla fragrance for women and men'),
			('Lira',
			'Xerjoff ',
			'Chris Maurice',
			'2011',
			'Lira by Xerjoff is a Amber Floral fragrance for women.'),
			('Mon Guerlain',
			'Guerlain ',
			'Delphine Jelk, Thierry Wasser',
			'2017',
			'Mon Guerlain by Guerlainis a Amber Woody fragrance for women.'),
			('Crystal Noir',
			'Versace',
			'Antoine Lie',
			'2004',
			'Crystal Noir by Versace is a Amber Floral fragrance for women.')
end