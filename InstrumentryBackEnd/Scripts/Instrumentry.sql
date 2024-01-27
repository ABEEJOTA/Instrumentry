create table public.instrument (
	id_instrument integer PRIMARY KEY not null,
	image varchar(200) not null,
	brand  varchar(200) not null,
	model varchar(200) not null,
	description character varying(200),
	price decimal,
	year_instrument integer
);