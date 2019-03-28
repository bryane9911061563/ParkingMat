-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 28-03-2019 a las 05:21:57
-- Versión del servidor: 10.1.21-MariaDB
-- Versión de PHP: 7.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `parking-mat`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cajones`
--

CREATE TABLE `cajones` (
  `id_cajon` int(11) NOT NULL,
  `id_sucursal` int(11) NOT NULL,
  `id_estado_cajon` int(10) NOT NULL,
  `id_tipo_vehiculo` int(11) NOT NULL,
  `Hora_inicio` varchar(30) CHARACTER SET utf8 COLLATE utf8_spanish2_ci NOT NULL,
  `Hora_final` varchar(30) CHARACTER SET utf8 COLLATE utf8_spanish2_ci NOT NULL,
  `Lugar` int(11) NOT NULL,
  `matricula` varchar(12) CHARACTER SET utf8 COLLATE utf8_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cajones`
--

INSERT INTO `cajones` (`id_cajon`, `id_sucursal`, `id_estado_cajon`, `id_tipo_vehiculo`, `Hora_inicio`, `Hora_final`, `Lugar`, `matricula`) VALUES
(45, 1, 1, 2, '09:50', '00:00', 1, 'dfsdf'),
(46, 1, 1, 1, '09:52', '00:00', 2, 'sdfasf'),
(47, 4, 1, 1, '09:55', '00:00', 3, 'safas'),
(48, 1, 3, 1, '11:55', 'Espac', 3, ''),
(49, 2, 3, 1, '12:04', 'Espac', 8, ''),
(50, 2, 3, 0, '12:04', 'Espac', 2, ''),
(51, 1, 3, 2, '01:40', 'Espac', 4, ''),
(52, 2, 3, 1, '01:41', 'Espac', 2, ''),
(53, 3, 3, 1, '01:47', 'Espac', 7, ''),
(54, 2, 3, 2, '01:49', 'Espac', 7, ''),
(55, 1, 3, 1, '01:51', 'Espac', 6, ''),
(56, 4, 3, 2, '01:59', 'Espac', 1, ''),
(57, 4, 3, 1, '08:18', 'Espac', 7, ''),
(58, 4, 3, 2, '08:19', 'Espac', 6, ''),
(59, 1, 3, 1, '10:42', 'Espac', 7, ''),
(60, 4, 1, 1, 'Hora ', 'Hora ', 3, ''),
(61, 4, 1, 2, 'Hora ', 'Hora ', 2, ''),
(62, 4, 1, 1, 'Hora entrada:09:24', 'Hora salida: --:--', 4, ''),
(63, 4, 1, 2, 'Hora entrada:09:32', 'Hora salida: --:--', 8, ''),
(64, 4, 1, 2, 'Hora entrada:09:35', 'Hora salida: --:--', 9, ''),
(65, 4, 1, 2, 'Hora entrada:09:38', 'Hora salida: --:--', 13, ''),
(66, 4, 2, 2, 'Hora entrada:09:42', 'Hora salida: 0:94', 12, 'fsdfsdf'),
(67, 4, 2, 2, 'Hora entrada:09:43', 'Hora salida: 0:94', 12, 'fsdfsdf'),
(68, 4, 2, 1, 'Hora entrada:09:43', 'Hora salida: 0:94', 12, 'fsdfsdf'),
(69, 4, 2, 1, 'Hora entrada:09:43', 'Hora salida: 0:94', 12, 'fsdfsdf'),
(70, 4, 2, 1, 'Hora entrada:09:45', 'Hora salida: 0:94', 12, 'fsdfsdf'),
(71, 4, 2, 2, 'Hora entrada:09:52', 'Hora salida: 0:95', 12, 'qweqwe'),
(72, 4, 2, 1, 'Hora entrada:09:52', 'Hora salida: 0:95', 12, 'qweqwe'),
(73, 4, 2, 1, 'Hora entrada:09:54', 'Hora salida:  :', 12, 'sdgsdg'),
(74, 4, 2, 1, 'Hora entrada:09:54', 'Hora salida:  :', 11, 'sdgsdg'),
(75, 4, 1, 2, 'Hora entrada:10:20', 'Hora salida: --:--', 12, 'sdfg'),
(76, 4, 1, 1, 'Hora entrada:10:20', 'Hora salida: --:--', 12, 'sdfg'),
(77, 4, 1, 1, 'Hora entrada:10:20', 'Hora salida: --:--', 12, 'sdfg');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `id_Cliente` int(11) NOT NULL,
  `Nombre_Cliente` varchar(50) CHARACTER SET utf8 COLLATE utf8_spanish2_ci NOT NULL,
  `Apellido_1_Cliente` varchar(50) CHARACTER SET utf8 COLLATE utf8_spanish2_ci NOT NULL,
  `Apellido_2_Cliente` varchar(50) CHARACTER SET utf8 COLLATE utf8_spanish2_ci NOT NULL,
  `id_Sucursal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

CREATE TABLE `empleados` (
  `id_Empleado` int(11) NOT NULL,
  `Nombre_Empleado` varchar(30) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `Apellido_1_Empleado` varchar(15) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `Apellido_2_Empleado` varchar(15) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `Fecha_Nacimiento` date NOT NULL,
  `id_puesto` int(11) NOT NULL,
  `Salario_Base` int(11) NOT NULL,
  `Correo_Electronico` varchar(25) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `Clave_Sesion` varchar(20) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `Horario` varchar(15) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `id_Sucursal` int(11) NOT NULL,
  `imagen` mediumtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `empleados`
--

INSERT INTO `empleados` (`id_Empleado`, `Nombre_Empleado`, `Apellido_1_Empleado`, `Apellido_2_Empleado`, `Fecha_Nacimiento`, `id_puesto`, `Salario_Base`, `Correo_Electronico`, `Clave_Sesion`, `Horario`, `id_Sucursal`, `imagen`) VALUES
(1, 'juan', 'perez', 'rojas', '2001-01-01', 1, 500, 'empleado@algo.com', '123456', 'Matutino', 1, NULL),
(2, 'Jordan', 'Amir', 'Loesa', '2001-01-01', 3, 700, 'JAmir@hotmail.com', '123456', 'Matutino', 3, NULL),
(5, 'juan', 'perez', 'rojas', '2001-01-01', 1, 500, '123', '123', 'Matutino', 4, NULL),
(6, '234', '234', '234', '2001-01-01', 3, 234, '234', '234', 'Matutino', 3, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estados_cajones`
--

CREATE TABLE `estados_cajones` (
  `id_estado_cajon` int(11) NOT NULL,
  `estado` varchar(30) CHARACTER SET utf8 COLLATE utf8_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `estados_cajones`
--

INSERT INTO `estados_cajones` (`id_estado_cajon`, `estado`) VALUES
(1, 'ocupado'),
(2, 'Final'),
(3, 'recerbado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pensionados`
--

CREATE TABLE `pensionados` (
  `id_pensionado` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellido_m` varchar(50) NOT NULL,
  `apellido_p` varchar(50) NOT NULL,
  `fecha_nac` datetime DEFAULT NULL,
  `fecha_registro` datetime DEFAULT NULL,
  `fecha_vencimiento` datetime DEFAULT NULL,
  `id_vehiculo` int(11) DEFAULT NULL,
  `telfono` varchar(14) NOT NULL,
  `correo` varchar(80) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `pensionados`
--

INSERT INTO `pensionados` (`id_pensionado`, `nombre`, `apellido_m`, `apellido_p`, `fecha_nac`, `fecha_registro`, `fecha_vencimiento`, `id_vehiculo`, `telfono`, `correo`) VALUES
(1, 'fasewfew', '123', '123', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0000-00-00 00:00:00', NULL, '', ''),
(2, 'retewrt', 'wertwert', 'wertwert', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0000-00-00 00:00:00', NULL, '', ''),
(3, 'qwe', 'qwe', 'qwe', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0000-00-00 00:00:00', NULL, '', ''),
(4, 'gfsdfgs', 'dsfgdsfg', 'sdfgsdg', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0000-00-00 00:00:00', NULL, '', ''),
(5, 'gsdfg', 'sdgf', 'sdgf', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0000-00-00 00:00:00', NULL, '', ''),
(6, 'trerte', 'ewtwet', 'ewrtwe', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0000-00-00 00:00:00', NULL, '', ''),
(7, 'ultimo', 'aaaaaaaaaaa', 'aaaaaaa', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0000-00-00 00:00:00', NULL, '', ''),
(8, 'dfgdsg', 'sdfgsdfg', 'dsgsdfg', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0000-00-00 00:00:00', NULL, '', ''),
(9, '', '', '', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0000-00-00 00:00:00', NULL, '', ''),
(10, 'qeqweq', 'wee', 'qweqwe', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0000-00-00 00:00:00', NULL, '', ''),
(11, '', '', '', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '0000-00-00 00:00:00', NULL, '', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `recibos`
--

CREATE TABLE `recibos` (
  `id_Recibo` int(11) NOT NULL,
  `Fecha_Creacion` date NOT NULL,
  `Costo` decimal(10,0) NOT NULL,
  `id_Tipo_Recibo` int(11) NOT NULL,
  `id_Scursal` int(11) NOT NULL,
  `descripcion` text CHARACTER SET utf8 COLLATE utf8_spanish2_ci NOT NULL,
  `motivo` varchar(30) CHARACTER SET utf8 COLLATE utf8_spanish2_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `recibos`
--

INSERT INTO `recibos` (`id_Recibo`, `Fecha_Creacion`, `Costo`, `id_Tipo_Recibo`, `id_Scursal`, `descripcion`, `motivo`) VALUES
(1, '2019-00-27', '123', 2, 1, 'qwe', 'ada'),
(3, '2019-00-27', '123', 2, 1, 'qwe', 'ada'),
(4, '2019-00-27', '123', 2, 1, 'qwe', 'ada'),
(5, '2019-00-27', '1300', 1, 1, 'Pagamos el agua coño', 'Pago mensual de agua'),
(6, '2019-00-27', '324234', 2, 4, 'dssd', '2342');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reporte`
--

CREATE TABLE `reporte` (
  `id_Reporte` int(11) NOT NULL,
  `Fecha_Creacion` date NOT NULL,
  `Fecha_Comprendida` varchar(50) NOT NULL,
  `descripcion` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sucursales`
--

CREATE TABLE `sucursales` (
  `id_Sucursal` int(11) NOT NULL,
  `Nombre_Sucursal` varchar(50) CHARACTER SET utf8 COLLATE utf8_spanish2_ci NOT NULL,
  `Direccion_Sucursal` varchar(100) CHARACTER SET utf8 COLLATE utf8_spanish2_ci NOT NULL,
  `Horario_Apertura` varchar(10) CHARACTER SET utf8 COLLATE utf8_spanish2_ci NOT NULL,
  `Horario_Cierre` varchar(10) CHARACTER SET utf8 COLLATE utf8_spanish2_ci NOT NULL,
  `Numero_Telefonico` varchar(12) CHARACTER SET utf16 COLLATE utf16_spanish2_ci NOT NULL,
  `Cantidad_Cajones` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `sucursales`
--

INSERT INTO `sucursales` (`id_Sucursal`, `Nombre_Sucursal`, `Direccion_Sucursal`, `Horario_Apertura`, `Horario_Cierre`, `Numero_Telefonico`, `Cantidad_Cajones`) VALUES
(1, 'la mejorada', 'calle 33 x 19/18 y #256 colonia Yucatan  ', '10:00', '22:00', '9㤹㤹', 60),
(2, 'la mejorada ii', 'calle 64 x 17  18 y 360 colonia mexico', '10:00', '22:00', '9㤹㤹', 60),
(3, 'Yucatan', 'Parque la Mejorada # 250', '07:00', '22:00', '㈱㐷㐸㌶㐷', 89),
(4, 'la caridad', 'alle 48 /65a #35 colonia centro', ' 7:00', '17:00', '(999)435-258', 86);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipos_vehiculos`
--

CREATE TABLE `tipos_vehiculos` (
  `id_tipo_vehiculo` int(11) NOT NULL,
  `tipo_vehiculo` varchar(30) CHARACTER SET utf8 COLLATE utf8_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipos_vehiculos`
--

INSERT INTO `tipos_vehiculos` (`id_tipo_vehiculo`, `tipo_vehiculo`) VALUES
(1, 'Compacto'),
(2, 'Grande'),
(3, 'Motocicleta');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_puesto`
--

CREATE TABLE `tipo_puesto` (
  `id_puesto` int(11) NOT NULL,
  `Puesto` varchar(30) CHARACTER SET utf8 COLLATE utf8_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipo_puesto`
--

INSERT INTO `tipo_puesto` (`id_puesto`, `Puesto`) VALUES
(1, 'Casetero'),
(2, 'Guardia'),
(3, 'Conserge'),
(4, 'Mandados');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_recibo`
--

CREATE TABLE `tipo_recibo` (
  `id_tipo_recibo` int(11) NOT NULL,
  `tipo_recibo` varchar(30) CHARACTER SET utf8 COLLATE utf8_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipo_recibo`
--

INSERT INTO `tipo_recibo` (`id_tipo_recibo`, `tipo_recibo`) VALUES
(1, 'Agua'),
(2, 'Cobro Cliente');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vehiculos`
--

CREATE TABLE `vehiculos` (
  `id_Vehiculo` int(11) NOT NULL,
  `Placas` varchar(15) CHARACTER SET utf8 COLLATE utf8_spanish2_ci NOT NULL,
  `Modelo` varchar(40) CHARACTER SET utf8 COLLATE utf8_spanish2_ci NOT NULL,
  `Color` varchar(40) CHARACTER SET utf8 COLLATE utf8_spanish2_ci NOT NULL,
  `id_Cliente` int(11) DEFAULT NULL,
  `id_Cajon` int(11) NOT NULL,
  `id_Tipo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `vehiculos`
--

INSERT INTO `vehiculos` (`id_Vehiculo`, `Placas`, `Modelo`, `Color`, `id_Cliente`, `id_Cajon`, `id_Tipo`) VALUES
(1, '', 'notyet', 'none', 7, 51, 1),
(2, '', 'notyet', 'none', 8, 47, 2),
(3, '', 'notyet', 'none', 9, 0, 0),
(4, '', 'notyet', 'none', 10, 57, 2),
(5, '', 'notyet', 'none', 11, 55, 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cajones`
--
ALTER TABLE `cajones`
  ADD PRIMARY KEY (`id_cajon`),
  ADD KEY `cajon-sucursal` (`id_sucursal`);

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id_Cliente`);

--
-- Indices de la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD PRIMARY KEY (`id_Empleado`),
  ADD KEY `empleado-sucursal` (`id_Sucursal`);

--
-- Indices de la tabla `estados_cajones`
--
ALTER TABLE `estados_cajones`
  ADD PRIMARY KEY (`id_estado_cajon`);

--
-- Indices de la tabla `pensionados`
--
ALTER TABLE `pensionados`
  ADD PRIMARY KEY (`id_pensionado`);

--
-- Indices de la tabla `recibos`
--
ALTER TABLE `recibos`
  ADD PRIMARY KEY (`id_Recibo`);

--
-- Indices de la tabla `reporte`
--
ALTER TABLE `reporte`
  ADD PRIMARY KEY (`id_Reporte`);

--
-- Indices de la tabla `sucursales`
--
ALTER TABLE `sucursales`
  ADD PRIMARY KEY (`id_Sucursal`);

--
-- Indices de la tabla `tipos_vehiculos`
--
ALTER TABLE `tipos_vehiculos`
  ADD PRIMARY KEY (`id_tipo_vehiculo`);

--
-- Indices de la tabla `tipo_puesto`
--
ALTER TABLE `tipo_puesto`
  ADD PRIMARY KEY (`id_puesto`);

--
-- Indices de la tabla `tipo_recibo`
--
ALTER TABLE `tipo_recibo`
  ADD PRIMARY KEY (`id_tipo_recibo`);

--
-- Indices de la tabla `vehiculos`
--
ALTER TABLE `vehiculos`
  ADD PRIMARY KEY (`id_Vehiculo`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cajones`
--
ALTER TABLE `cajones`
  MODIFY `id_cajon` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=78;
--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id_Cliente` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `empleados`
--
ALTER TABLE `empleados`
  MODIFY `id_Empleado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT de la tabla `estados_cajones`
--
ALTER TABLE `estados_cajones`
  MODIFY `id_estado_cajon` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `pensionados`
--
ALTER TABLE `pensionados`
  MODIFY `id_pensionado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT de la tabla `recibos`
--
ALTER TABLE `recibos`
  MODIFY `id_Recibo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT de la tabla `reporte`
--
ALTER TABLE `reporte`
  MODIFY `id_Reporte` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `sucursales`
--
ALTER TABLE `sucursales`
  MODIFY `id_Sucursal` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `tipos_vehiculos`
--
ALTER TABLE `tipos_vehiculos`
  MODIFY `id_tipo_vehiculo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `tipo_puesto`
--
ALTER TABLE `tipo_puesto`
  MODIFY `id_puesto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `tipo_recibo`
--
ALTER TABLE `tipo_recibo`
  MODIFY `id_tipo_recibo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `vehiculos`
--
ALTER TABLE `vehiculos`
  MODIFY `id_Vehiculo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `cajones`
--
ALTER TABLE `cajones`
  ADD CONSTRAINT `cajon-sucursal` FOREIGN KEY (`id_sucursal`) REFERENCES `sucursales` (`id_Sucursal`);

--
-- Filtros para la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD CONSTRAINT `empleado-sucursal` FOREIGN KEY (`id_Sucursal`) REFERENCES `sucursales` (`id_Sucursal`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
