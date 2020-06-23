/*
Navicat MySQL Data Transfer

Source Server         : lin
Source Server Version : 50149
Source Host           : localhost:3306
Source Database       : studentsmanage

Target Server Type    : MYSQL
Target Server Version : 50149
File Encoding         : 65001

Date: 2020-06-16 18:38:41
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for t_course
-- ----------------------------
DROP TABLE IF EXISTS `t_course`;
CREATE TABLE `t_course` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cid` varchar(11) DEFAULT NULL,
  `cname` varchar(50) DEFAULT NULL,
  `remake` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_course
-- ----------------------------
INSERT INTO `t_course` VALUES ('1', 'C01', 'C#', '高级编程语言');
INSERT INTO `t_course` VALUES ('2', 'C02', 'JavaScript', 'Web的编程语言');
INSERT INTO `t_course` VALUES ('3', 'C03', 'Vue', '一套构建用户界面的渐进式框架');
INSERT INTO `t_course` VALUES ('5', 'C05', 'Jquery', '一个快速、简洁的JavaScript框架');
INSERT INTO `t_course` VALUES ('6', 'C06', 'element-ui', '一套为开发者、设计师和产品经理准备的基于 Vue 2.0 的桌面端组件库');
INSERT INTO `t_course` VALUES ('7', 'C07', 'bootstrap', '目前最受欢迎的前端框架');
INSERT INTO `t_course` VALUES ('8', 'C08', 'a', 'b测试');
INSERT INTO `t_course` VALUES ('11', 'C10', 'ceshi', 'adceshi');
INSERT INTO `t_course` VALUES ('13', 'C013', 'li', 'hua');
INSERT INTO `t_course` VALUES ('15', 'C09', 'd', 'e');

-- ----------------------------
-- Table structure for t_students
-- ----------------------------
DROP TABLE IF EXISTS `t_students`;
CREATE TABLE `t_students` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `sid` varchar(11) DEFAULT NULL,
  `sname` varchar(50) DEFAULT NULL,
  `sex` varchar(50) DEFAULT NULL,
  `age` int(10) DEFAULT NULL,
  `major` varchar(50) DEFAULT NULL,
  `cid` varchar(11) DEFAULT NULL,
  `class_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_students
-- ----------------------------
INSERT INTO `t_students` VALUES ('1', '1001', 'Carol', '女', '13', '物流管理', 'C06', '4');
INSERT INTO `t_students` VALUES ('2', '1002', 'Maria', '女', '12', '计算机', 'C01', '1');
INSERT INTO `t_students` VALUES ('3', '1003', 'Rose', '女', '13', '外国语言与外国历史', 'C04', '3');
INSERT INTO `t_students` VALUES ('4', '1004', 'Daisy', '女', '13', '汉语国际教育', 'C06', '4');
INSERT INTO `t_students` VALUES ('5', '1005', 'Kangkang', '男', '13', '旅游', 'C03', '3');
INSERT INTO `t_students` VALUES ('6', '1006', 'Bettyas', '男', '17', '文化艺术', 'C02', '5');
INSERT INTO `t_students` VALUES ('7', '1007', 'Jasmine', '女', '13', '网络与新媒体', 'C05', '5');
INSERT INTO `t_students` VALUES ('13', '1010', 'dv', '男', '18', 'ceshi', 'C01', '1');
INSERT INTO `t_students` VALUES ('16', '6', '6测试', '男', '18', '6', 'C01', '1');
INSERT INTO `t_students` VALUES ('22', '1013', 'lihua', '女', '18', '计算机', 'C01', '1');

-- ----------------------------
-- Table structure for t_user
-- ----------------------------
DROP TABLE IF EXISTS `t_user`;
CREATE TABLE `t_user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_user
-- ----------------------------
INSERT INTO `t_user` VALUES ('1', 'coco', '222222');
