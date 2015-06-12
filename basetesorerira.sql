CREATE TABLE configuracion
(
  municipio VARCHAR(92),
  presidente VARCHAR(48),
  tesorero VARCHAR(48),
  ultimafactura INT(12),
  datos_ano INT(4),
  diacobro INT(2),
  textoagua TEXT,
  textopredio TEXT
)ENGINE=INNODB;

CREATE TABLE usuarios
(
  id INT NOT NULL AUTO_INCREMENT,
  nombre VARCHAR(24) not null,
  clave VARCHAR(32) not null,
  PRIMARY KEY(id)
  )ENGINE=INNODB;

CREATE TABLE localidades
(
	id_localidad INT NOT NULL auto_increment,
	nombre VARCHAR(48),
	PRIMARY KEY (id_localidad)
)ENGINE=INNODB;

CREATE TABLE calles
(
	id_calle INT NOT NULL auto_increment,
	localidad VARCHAR(48),
	nombre VARCHAR(48),
	PRIMARY KEY(id_calle)
)ENGINE=INNODB;

CREATE TABLE contribuyente
(
	id INT NOT NULL auto_increment,
	nombre VARCHAR(48),
	calle VARCHAR(48),
	numero VARCHAR(8),
	localidad VARCHAR(48),
	PRIMARY KEY (id)
) ENGINE=INNODB;

CREATE TABLE tarifasagua
(
  id_tarifa INT NOT NULL auto_increment,
  nombre VARCHAR(24) NOT NULL,
  PRIMARY KEY(id_tarifa)
)ENGINE=INNODB;

CREATE TABLE detarifagua
(
  id_detalle INT NOT NULL auto_increment,
  id_tarifa INT NOT NULL,
  costo DECIMAL(12) NOT NULL,
  apar_mes INT(2) NOT NULL,
  apar_ano INT(4) NOT NULL,
  PRIMARY KEY(id_detalle),
  INDEX (id_tarifa),
  FOREIGN KEY (id_tarifa) REFERENCES tarifasagua(id_tarifa)
);

CREATE TABLE configagua
(
  diacobro int(2) default 0,
  costoregistro decimal(6,2) default 0
) ENGINE=INNODB;

  

CREATE TABLE aguapotable
(
  id_toma INT NOT NULL auto_increment,
  tomas INT(2) NOT NULL,
  id_tarifa INT NOT NULL,
  nombre VARCHAR(48) NOT NULL,
  localidad VARCHAR(48),
  calle VARCHAR(48),
  numero VARCHAR(8),
  ultimopago DATE,
  pagohasta VARCHAR(7),
  estado VARCHAR(12) NOT NULL,
  fechacancel VARCHAR(10),
  adeudo DECIMAL(12,2),
  observaciones VARCHAR(128),
  PRIMARY KEY(id_toma),
  INDEX(id_tarifa),
  FOREIGN KEY(id_tarifa) REFERENCES tarifasagua(id_tarifa)
) ENGINE=INNODB;

CREATE TABLE cobroagua
(
  id_cobro INT NOT NULL auto_increment,
  nofactura INT(12) NOT NULL,
  id_toma INT NOT NULL,
  id_tarifa INT NOT NULL,
  nombre VARCHAR(48) NOT NULL,
  localidad VARCHAR(48),
  calle VARCHAR(32),
  numero VARCHAR(8),
  pagodesde VARCHAR(7) NOT NULL,
  pagohasta VARCHAR(7) NOT NULL,
  tomas INT(2),
  meses INT(12),
  importe DECIMAL(12,2) NOT NULL,
  fechapago DATE NOT NULL,
  observaciones TEXT,
  PRIMARY KEY(id_cobro),
  INDEX(id_toma),
  INDEX(id_tarifa),
  FOREIGN KEY(id_toma) REFERENCES aguapotable(id_toma),
  FOREIGN KEY(id_tarifa) REFERENCES tarifasagua(id_tarifa)
)ENGINE=INNODB;

CREATE TABLE detcobagua
(
  id_det INT NOT NULL AUTO_INCREMENT,
  id_cobro INT NOT NULL,
  periodo VARCHAR(48) NOT NULL,
  p_unit DECIMAL(6) NOT NULL,
  totalmeses INT(2) NOT NULL,
  importe DECIMAL(12,2) not null,
  PRIMARY KEY(id_det),
  INDEX (id_cobro),
  FOREIGN KEY(id_cobro) REFERENCES cobroagua(id_cobro)
)ENGINE=INNODB;


CREATE TABLE configregcivil
(
  id_tipo INT NOT NULL AUTO_INCREMENT,
  tipo VARCHAR(48) NOT NULL,
  nombre VARCHAR(48) NOT NULL,
  costo DECIMAL(6,2) NOT NULL DEFAULT 0,
  PRIMARY KEY(id_tipo)
)ENGINE=INNODB;

CREATE TABLE cobroregcivil
(
  id_reg INT NOT NULL AUTO_INCREMENT,
  nofactura INT(12) NOT NULL,
  nombre VARCHAR(48) NOT NULL,
  localidad VARCHAR(48),
  calle VARCHAR(32),
  numero VARCHAR(8),
  descripcion VARCHAR(128) NOT NULL,
  conceptos int(2) NOT NULL,
  importe DECIMAL(12,2) NOT NULL,
  fecha DATE NOT NULL,
  comentario TEXT,
  PRIMARY KEY(id_reg)
)ENGINE=INNODB;

CREATE TABLE detallesregcivil
(
  id_detalle INT NOT NULL AUTO_INCREMENT,
  id_reg INT NOT NULL,
  tipo VARCHAR(48),
  nombre VARCHAR(48) NOT NULL,
  folio VARCHAR(10),
  costo DECIMAL(7,2) NOT NULL,
  fecha DATE NOT NULL,
  comentario VARCHAR(64),
  PRIMARY KEY (id_detalle),
  INDEX(id_reg),
  FOREIGN KEY(id_reg) REFERENCES cobroregcivil(id_reg)
)ENGINE=INNODB;

CREATE TABLE configmaquina
(
  id INT NOT NULL AUTO_INCREMENT,
  trabajode VARCHAR(10) NOT NULL,
  descripcion VARCHAR(48) NOT NULL,
  costo DECIMAL(12,2) DEFAULT 0,
  PRIMARY KEY(id)
)ENGINE=INNODB;

CREATE TABLE cobromaquina
(
  id_cobro INT NOT NULL AUTO_INCREMENT,
  nofactura INT(12) NOT NULL,
  nombre VARCHAR(48) NOT NULL,
  direccion VARCHAR(72),
  descripcion VARCHAR(128),
  conceptos int(3) NOT NULL,
  importe DECIMAL(12,2) NOT NULL,
  fecha DATE NOT NULL,
  comentario VARCHAR(128),
  PRIMARY KEY(id_cobro)
)ENGINE=INNODB;

CREATE TABLE detcobromaq
(
  id_detalle INT NOT NULL AUTO_INCREMENT,
  id_cobro INT NOT NULL,
  concepto VARCHAR(48) NOT NULL,
  cantidad DECIMAL(2,1) NOT NULL,
  costo DECIMAL(5,2) NOT NULL,
  importe DECIMAL(7,2) NOT NULL,
  PRIMARY KEY (id_detalle),
  INDEX(id_cobro),
  FOREIGN KEY(id_cobro) REFERENCES cobromaquina(id_cobro)
)ENGINE=INNODB;

CREATE TABLE ubicrusticos
(
  id INT NOT NULL AUTO_INCREMENT,
  nombre VARCHAR(48) NOT NULL,
  PRIMARY KEY(id)
)ENGINE=INNODB;

CREATE TABLE inmuebles
(
  id_inmueble INT NOT NULL AUTO_INCREMENT,
  cuenta INT(8) NOT NULL,
  tipo VARCHAR(16) NOT NULL,
  ubicacion  VARCHAR(48),
  propietario VARCHAR(24) NOT NULL,
  direccion VARCHAR(64),
  pagadohasta INT(4) NOT NULL,
  ultimopago date not null,
  adeudo DECIMAL(6) NULL DEFAULT 0,
  observaciones text,
  PRIMARY KEY(id_inmueble)
)ENGINE=INNODB;

CREATE TABLE impuestospred
(
  id_imp INT NOT NULL AUTO_INCREMENT,
  id_inmueble INT NOT NULL,
  imp2003 DECIMAL(6,2) NULL DEFAULT 0,
  imp2004 DECIMAL(6,2) NULL DEFAULT 0,
  imp2005 DECIMAL(6,2) NULL DEFAULT 0,
  imp2006 DECIMAL(6,2) NULL DEFAULT 0,
  imp2007 DECIMAL(6,2) NULL DEFAULT 0,
  PRIMARY KEY(id_imp),
  INDEX(id_inmueble),
  FOREIGN KEY(id_inmueble) REFERENCES inmuebles(id_inmueble)
)ENGINE=INNODB;

CREATE TABLE cobropredios
(
  id_cobro INT NOT NULL auto_increment,
  id_inmueble INT(12) NOT NULL,
  cuenta INT(12) NOT NULL,
  ubicacion VARCHAR(64),
  tipo VARCHAR(16) NOT NULL,
  propietario VARCHAR(48) NOT NULL,
  direccion VARCHAR(72),
  anoscobrados VARCHAR(64),
  importe DECIMAL(12,2) NOT NULL,
  observaciones Text,
  fecha DATE NOT NULL,
  PRIMARY KEY(id_cobro),
  INDEX(id_inmueble),
  FOREIGN KEY(id_inmueble) REFERENCES inmuebles(id_inmueble)
)ENGINE=INNODB;

CREATE TABLE detcobropredios
(
  id_det INT NOT NULL AUTO_INCREMENT,
  id_cobro INT NOT NULL,
  anopagado VARCHAR(8) NOT NULL,
  impuesto DECIMAL(6,2),
  PRIMARY KEY(id_det),
  INDEX(id_cobro),
  FOREIGN KEY(id_cobro) REFERENCES cobropredios(id_cobro)
)ENGINE=INNODB;


CREATE TABLE tortilleria
(
  id INT NOT NULL AUTO_INCREMENT,
  nofactura INT(12) NOT NULL,
  periodo VARCHAR(32),
  importe DECIMAL(6,2),
  fecha DATE NOT NULL,
  PRIMARY KEY(id)
)ENGINE=INNODB;

CREATE TABLE otrosing
(
  id INT NOT NULL AUTO_INCREMENT,
  nofactura INT(12) NOT NULL,
  nombre VARCHAR(32),
  domicilio VARCHAR(48),
  concepto VARCHAR(42),
  importe DECIMAL(12,2),
  fecha DATE,
  PRIMARY KEY(id)
)ENGINE=innodb;

CREATE TABLE cuentas
(
 id INT NOT NULL AUTO_INCREMENT,
 numero VARCHAR(16) not null,
 nombrecta VARCHAR(128) NOT NULL,
 descripcion text null,
 depositado DECIMAL(12,2) DEFAULT 0,
 retirado DECIMAL(12,2) DEFAULT 0,
 saldo DECIMAL(12,2) DEFAULT 0,
PRIMARY KEY(id)
)ENGINE=INNODB;


CREATE TABLE depositosip
(
  id_deposito INT NOT NULL AUTO_INCREMENT,
  nombrecta VARCHAR(128) NOT NULL,
  ficha VARCHAR(64),
  cantidad DECIMAL(12,2) NOT NULL,
  fecha DATE NOT NULL,
  PRIMARY KEY(id_deposito)
)ENGINE=INNODB;

CREATE TABLE ingpropios
(
  id_ing INT NOT NULL AUTO_INCREMENT,
  fecha DATE NOT NULL,
  concepto VARCHAR(32),
  ingreso DECIMAL(16,2),
  PRIMARY KEY (id_ing)
)ENGINE=innodb;

CREATE TABLE ingpropiosres
(
  ingresos DECIMAL(14,2) DEFAULT 0,
  egresos DECIMAL(14,2) DEFAULT 0,
  depositado DECIMAL(14,2) DEFAULT 0,
  retirado DECIMAL(14,2) DEFAULT 0,
  encaja DECIMAL(14,2) DEFAULT 0,
  enbanco DECIMAL(14,2) DEFAULT 0
)ENGINE=innodb;


CREATE TABLE egresosip
(
  id_egreso INT NOT NULL AUTO_INCREMENT,
  nombrecta VARCHAR(128) NOT NULL,
  fecha DATE NOT NULL,
  cantidad DECIMAL(12,2) NOT NULL,
  origen VARCHAR(8) NOT NULL,
  cheque VARCHAR(64),
  destino VARCHAR(64) NOT NULL,
  anombrede VARCHAR(48) NOT NULL,
  cargo VARCHAR(48),
  PRIMARY KEY(id_egreso)
)ENGINE=INNODB;


CREATE TABLE cajachicares
(
  ingresos DECIMAL(12,2),
  egresos DECIMAL(12,2),
  encaja DECIMAL(12,2)
);

CREATE TABLE ingresosch
(
  id_ingch INT NOT NULL AUTO_INCREMENT,
  fecha date NOT NULL,
  cantidad  DECIMAL(12,2) NOT NULL,
  nocheque VARCHAR(32) NOT NULL,
  PRIMARY KEY(id_ingch)
);

CREATE TABLE egresosch
(
  id_egreso INT NOT NULL AUTO_INCREMENT,
  fecha DATE,
  cantidad DECIMAL(16,2),
  destino VARCHAR(64),
  anombrede VARCHAR(48),
  cargo VARCHAR(48),
  PRIMARY KEY(id_egreso)
);

CREATE TABLE factcancel
(
  id INT NOT NULL AUTO_INCREMENT,
  factura int(12) not null,
  anombrede VARCHAR(48),
  descripcion varchar(128),
  fecha DATE,
  PRIMARY KEY(id)
)ENGINE=INNODB;