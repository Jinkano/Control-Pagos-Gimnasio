-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 08-04-2025 a las 23:36:19
-- Versión del servidor: 8.4.4
-- Versión de PHP: 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `control_pagos`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE IF NOT EXISTS `clientes` (
  `id_cli` tinyint NOT NULL AUTO_INCREMENT,
  `nom_cli` char(30) NOT NULL,
  `ape_cli` char(30) NOT NULL,
  `fdn_cli` date NOT NULL,
  `tlf_cli` char(15) NOT NULL,
  `eml_cli` char(50) NOT NULL,
  `dir_cli` char(100) NOT NULL,
  `fdi_cli` date NOT NULL,
  `std_cli` char(2) NOT NULL,
  PRIMARY KEY (`id_cli`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagos`
--

DROP TABLE IF EXISTS `pagos`;
CREATE TABLE IF NOT EXISTS `pagos` (
  `id_pgs` tinyint NOT NULL AUTO_INCREMENT,
  `fdi_pgs` date NOT NULL,
  `fdp_pgs` date NOT NULL,
  `frm_pgs` char(15) NOT NULL,
  `prc_pgs` decimal(5,2) NOT NULL,
  `dsc_pgs` decimal(5,2) NOT NULL,
  `id_cli` tinyint NOT NULL,
  PRIMARY KEY (`id_pgs`),
  KEY `FOREIGN KEY` (`id_cli`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tarifas`
--

DROP TABLE IF EXISTS `tarifas`;
CREATE TABLE IF NOT EXISTS `tarifas` (
  `id_tarifa` tinyint NOT NULL AUTO_INCREMENT,
  `precio` decimal(5,2) NOT NULL,
  `e_min` tinyint NOT NULL,
  `e_max` tinyint NOT NULL,
  `dscto` decimal(5,2) NOT NULL,
  PRIMARY KEY (`id_tarifa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `pagos`
--
ALTER TABLE `pagos`
  ADD CONSTRAINT `PK_ID_CLIENTE_FK` FOREIGN KEY (`id_cli`) REFERENCES `clientes` (`id_cli`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
