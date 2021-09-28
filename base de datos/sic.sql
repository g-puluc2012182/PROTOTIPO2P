-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 28-09-2021 a las 17:58:38
-- Versión del servidor: 5.7.31
-- Versión de PHP: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `sic`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bodegas`
--

DROP TABLE IF EXISTS `bodegas`;
CREATE TABLE IF NOT EXISTS `bodegas` (
  `codigo_bodega` varchar(5) NOT NULL,
  `nombre_bodega` varchar(60) DEFAULT NULL,
  `estatus_bodega` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codigo_bodega`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `bodegas`
--

INSERT INTO `bodegas` (`codigo_bodega`, `nombre_bodega`, `estatus_bodega`) VALUES
('', '', ''),
('1', 'CENTRAL', '1'),
('2', 'OFIPACK', '0'),
('3', 'TERMINAL', '0'),
('4', 'primaria', '1'),
('5', 'OFIBODEGAS', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE IF NOT EXISTS `clientes` (
  `codigo_cliente` varchar(5) NOT NULL,
  `nombre_cliente` varchar(60) DEFAULT NULL,
  `direccion_cliente` varchar(60) DEFAULT NULL,
  `nit_cliente` varchar(20) DEFAULT NULL,
  `telefono_cliente` varchar(50) DEFAULT NULL,
  `codigo_vendedor` varchar(5) DEFAULT NULL,
  `estatus_cliente` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codigo_cliente`),
  KEY `codigo_vendedor` (`codigo_vendedor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compras_detalle`
--

DROP TABLE IF EXISTS `compras_detalle`;
CREATE TABLE IF NOT EXISTS `compras_detalle` (
  `documento_compraenca` varchar(10) NOT NULL,
  `codigo_producto` varchar(18) NOT NULL,
  `cantidad_compradet` float(10,2) DEFAULT NULL,
  `costo_compradet` float(10,2) DEFAULT NULL,
  `codigo_bodega` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`documento_compraenca`,`codigo_producto`),
  KEY `codigo_producto` (`codigo_producto`),
  KEY `codigo_bodega` (`codigo_bodega`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compras_encabezado`
--

DROP TABLE IF EXISTS `compras_encabezado`;
CREATE TABLE IF NOT EXISTS `compras_encabezado` (
  `documento_compraenca` varchar(10) NOT NULL,
  `codigo_proveedor` varchar(5) DEFAULT NULL,
  `fecha_compraenca` date DEFAULT NULL,
  `total_compraenca` float(10,2) DEFAULT NULL,
  `estatus_compraenca` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`documento_compraenca`),
  KEY `codigo_proveedor` (`codigo_proveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `existencias`
--

DROP TABLE IF EXISTS `existencias`;
CREATE TABLE IF NOT EXISTS `existencias` (
  `codigo_bodega` varchar(5) NOT NULL,
  `codigo_producto` varchar(18) NOT NULL,
  `saldo_existencia` float(10,2) DEFAULT NULL,
  PRIMARY KEY (`codigo_bodega`,`codigo_producto`),
  KEY `codigo_producto` (`codigo_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `existencias`
--

INSERT INTO `existencias` (`codigo_bodega`, `codigo_producto`, `saldo_existencia`) VALUES
('5', '2', 3.00);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `lineas`
--

DROP TABLE IF EXISTS `lineas`;
CREATE TABLE IF NOT EXISTS `lineas` (
  `codigo_linea` varchar(5) NOT NULL,
  `nombre_linea` varchar(60) DEFAULT NULL,
  `estatus_linea` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codigo_linea`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `lineas`
--

INSERT INTO `lineas` (`codigo_linea`, `nombre_linea`, `estatus_linea`) VALUES
('', '', ''),
('1', 'SEMILLAS', '0'),
('2', 'carne', '1'),
('3', 'LACTEOS', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marcas`
--

DROP TABLE IF EXISTS `marcas`;
CREATE TABLE IF NOT EXISTS `marcas` (
  `codigo_marca` varchar(5) NOT NULL,
  `nombre_marca` varchar(60) DEFAULT NULL,
  `estatus_marca` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codigo_marca`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `marcas`
--

INSERT INTO `marcas` (`codigo_marca`, `nombre_marca`, `estatus_marca`) VALUES
('', '', ''),
('1', 'agroindustria', '0'),
('2', 'procasa', '1'),
('3', 'LALA', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

DROP TABLE IF EXISTS `productos`;
CREATE TABLE IF NOT EXISTS `productos` (
  `codigo_producto` varchar(18) NOT NULL,
  `nombre_producto` varchar(60) DEFAULT NULL,
  `codigo_linea` varchar(5) DEFAULT NULL,
  `codigo_marca` varchar(5) DEFAULT NULL,
  `existencia_producto` float(10,2) DEFAULT NULL,
  `estatus_producto` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codigo_producto`),
  KEY `codigo_linea` (`codigo_linea`),
  KEY `codigo_marca` (`codigo_marca`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`codigo_producto`, `nombre_producto`, `codigo_linea`, `codigo_marca`, `existencia_producto`, `estatus_producto`) VALUES
('1', 'carnes', '2', '1', 1.00, '1'),
('2', 'LACTEOS', '3', '3', 2.00, '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedores`
--

DROP TABLE IF EXISTS `proveedores`;
CREATE TABLE IF NOT EXISTS `proveedores` (
  `codigo_proveedor` varchar(5) NOT NULL,
  `nombre_proveedor` varchar(60) DEFAULT NULL,
  `direccion_proveedor` varchar(60) DEFAULT NULL,
  `telefono_proveedor` varchar(50) DEFAULT NULL,
  `nit_proveedor` varchar(50) DEFAULT NULL,
  `estatus_proveedor` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codigo_proveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vendedores`
--

DROP TABLE IF EXISTS `vendedores`;
CREATE TABLE IF NOT EXISTS `vendedores` (
  `codigo_vendedor` varchar(5) NOT NULL,
  `nombre_vendedor` varchar(60) DEFAULT NULL,
  `direccion_vendedor` varchar(60) DEFAULT NULL,
  `telefono_vendedor` varchar(50) DEFAULT NULL,
  `nit_vendedor` varchar(20) DEFAULT NULL,
  `estatus_vendedor` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`codigo_vendedor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas_detalle`
--

DROP TABLE IF EXISTS `ventas_detalle`;
CREATE TABLE IF NOT EXISTS `ventas_detalle` (
  `documento_ventaenca` varchar(10) NOT NULL,
  `codigo_producto` varchar(18) NOT NULL,
  `cantidad_ventadet` float(10,2) DEFAULT NULL,
  `costo_ventadet` float(10,2) DEFAULT NULL,
  `precio_ventadet` float(10,2) DEFAULT NULL,
  `codigo_bodega` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`documento_ventaenca`,`codigo_producto`),
  KEY `codigo_producto` (`codigo_producto`),
  KEY `codigo_bodega` (`codigo_bodega`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas_encabezado`
--

DROP TABLE IF EXISTS `ventas_encabezado`;
CREATE TABLE IF NOT EXISTS `ventas_encabezado` (
  `documento_ventaenca` varchar(10) NOT NULL,
  `codigo_cliente` varchar(5) DEFAULT NULL,
  `fecha_ventaenca` date DEFAULT NULL,
  `total_ventaenca` float(10,2) DEFAULT NULL,
  `estatus_ventaenca` varchar(1) DEFAULT NULL,
  PRIMARY KEY (`documento_ventaenca`),
  KEY `codigo_cliente` (`codigo_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD CONSTRAINT `clientes_ibfk_1` FOREIGN KEY (`codigo_vendedor`) REFERENCES `vendedores` (`codigo_vendedor`);

--
-- Filtros para la tabla `compras_detalle`
--
ALTER TABLE `compras_detalle`
  ADD CONSTRAINT `compras_detalle_ibfk_1` FOREIGN KEY (`documento_compraenca`) REFERENCES `compras_encabezado` (`documento_compraenca`),
  ADD CONSTRAINT `compras_detalle_ibfk_2` FOREIGN KEY (`codigo_producto`) REFERENCES `productos` (`codigo_producto`),
  ADD CONSTRAINT `compras_detalle_ibfk_3` FOREIGN KEY (`codigo_bodega`) REFERENCES `bodegas` (`codigo_bodega`);

--
-- Filtros para la tabla `compras_encabezado`
--
ALTER TABLE `compras_encabezado`
  ADD CONSTRAINT `compras_encabezado_ibfk_1` FOREIGN KEY (`codigo_proveedor`) REFERENCES `proveedores` (`codigo_proveedor`);

--
-- Filtros para la tabla `existencias`
--
ALTER TABLE `existencias`
  ADD CONSTRAINT `existencias_ibfk_1` FOREIGN KEY (`codigo_bodega`) REFERENCES `bodegas` (`codigo_bodega`),
  ADD CONSTRAINT `existencias_ibfk_2` FOREIGN KEY (`codigo_producto`) REFERENCES `productos` (`codigo_producto`);

--
-- Filtros para la tabla `productos`
--
ALTER TABLE `productos`
  ADD CONSTRAINT `productos_ibfk_1` FOREIGN KEY (`codigo_linea`) REFERENCES `lineas` (`codigo_linea`),
  ADD CONSTRAINT `productos_ibfk_2` FOREIGN KEY (`codigo_marca`) REFERENCES `marcas` (`codigo_marca`);

--
-- Filtros para la tabla `ventas_detalle`
--
ALTER TABLE `ventas_detalle`
  ADD CONSTRAINT `ventas_detalle_ibfk_1` FOREIGN KEY (`documento_ventaenca`) REFERENCES `ventas_encabezado` (`documento_ventaenca`),
  ADD CONSTRAINT `ventas_detalle_ibfk_2` FOREIGN KEY (`codigo_producto`) REFERENCES `productos` (`codigo_producto`),
  ADD CONSTRAINT `ventas_detalle_ibfk_3` FOREIGN KEY (`codigo_bodega`) REFERENCES `bodegas` (`codigo_bodega`);

--
-- Filtros para la tabla `ventas_encabezado`
--
ALTER TABLE `ventas_encabezado`
  ADD CONSTRAINT `ventas_encabezado_ibfk_1` FOREIGN KEY (`codigo_cliente`) REFERENCES `clientes` (`codigo_cliente`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
