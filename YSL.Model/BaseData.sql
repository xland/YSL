-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: ysl_db
-- ------------------------------------------------------
-- Server version	5.7.17-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `hrm_course`
--

DROP TABLE IF EXISTS `hrm_course`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_course` (
  `id` varchar(38) NOT NULL,
  `course_name` varchar(180) DEFAULT NULL,
  `des` varchar(3800) DEFAULT NULL,
  `level` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_course`
--

LOCK TABLES `hrm_course` WRITE;
/*!40000 ALTER TABLE `hrm_course` DISABLE KEYS */;
/*!40000 ALTER TABLE `hrm_course` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hrm_course_doc`
--

DROP TABLE IF EXISTS `hrm_course_doc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_course_doc` (
  `id` varchar(38) NOT NULL,
  `course_id` varchar(38) DEFAULT NULL,
  `doc_url` varchar(560) DEFAULT NULL,
  `des` varchar(380) DEFAULT NULL,
  `order_num` int(11) DEFAULT NULL,
  `is_out_date` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_course_doc`
--

LOCK TABLES `hrm_course_doc` WRITE;
/*!40000 ALTER TABLE `hrm_course_doc` DISABLE KEYS */;
/*!40000 ALTER TABLE `hrm_course_doc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hrm_course_teacher`
--

DROP TABLE IF EXISTS `hrm_course_teacher`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_course_teacher` (
  `id` varchar(38) NOT NULL,
  `employee_id` varchar(38) DEFAULT NULL,
  `account_id` varchar(38) DEFAULT NULL,
  `is_external` varchar(45) DEFAULT NULL,
  `teacher_name` varchar(45) DEFAULT NULL,
  `course_id` varchar(38) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_course_teacher`
--

LOCK TABLES `hrm_course_teacher` WRITE;
/*!40000 ALTER TABLE `hrm_course_teacher` DISABLE KEYS */;
/*!40000 ALTER TABLE `hrm_course_teacher` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hrm_department`
--

DROP TABLE IF EXISTS `hrm_department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_department` (
  `id` varchar(38) NOT NULL,
  `department_name` varchar(36) DEFAULT NULL,
  `order_num` int(11) DEFAULT NULL,
  `des` varchar(666) DEFAULT NULL,
  `pid` varchar(38) DEFAULT NULL,
  `telphone` varchar(38) DEFAULT NULL,
  `leader_account_id` varchar(38) DEFAULT NULL,
  `leader_employee_id` varchar(38) DEFAULT NULL,
  `leader_name` varchar(16) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_department`
--

LOCK TABLES `hrm_department` WRITE;
/*!40000 ALTER TABLE `hrm_department` DISABLE KEYS */;
INSERT INTO `hrm_department` VALUES ('16a58d1ff7344737a2ed60d40534507d','CKMS产品小组',0,NULL,'24ff908ad3804ccdb6ee08289ed52d0f',NULL,NULL,NULL,NULL),('1cc2c92293eb41309ead830d5ff624aa','UED设计小组',300,NULL,'5e7dd6deb9c547398562db9149f8fdf5',NULL,NULL,NULL,NULL),('24ff908ad3804ccdb6ee08289ed52d0f','客服产品部',200,NULL,'79e63714d1264c03ba9246f88e78ce3f',NULL,NULL,NULL,NULL),('273d95447dcd4961b3a93fac10bb8d42','前端开发小组',100,NULL,'5e7dd6deb9c547398562db9149f8fdf5',NULL,NULL,NULL,NULL),('4a248a73b66a4c629a18e83a28707647','华东事业部',0,NULL,'79e63714d1264c03ba9246f88e78ce3f',NULL,NULL,NULL,NULL),('4e9f42146ff94a2d9da31fc24f38180c','北方事业部',400,NULL,'79e63714d1264c03ba9246f88e78ce3f',NULL,NULL,NULL,NULL),('5e7dd6deb9c547398562db9149f8fdf5','技术研发部',100,NULL,'79e63714d1264c03ba9246f88e78ce3f',NULL,NULL,NULL,NULL),('71ec78679f2848d994bb0393bbe4a903','JAVA开发小组',200,NULL,'5e7dd6deb9c547398562db9149f8fdf5',NULL,NULL,NULL,NULL),('7473164dac5042a8bf57852bb3ceb83a','CCMS产品小组',0,NULL,'24ff908ad3804ccdb6ee08289ed52d0f',NULL,NULL,NULL,NULL),('79e63714d1264c03ba9246f88e78ce3f','浙江远传信息技术股份有限公司',0,NULL,NULL,NULL,NULL,NULL,NULL),('aeb6d8daf88d4d4b88ea0e1a32fff535','语音分析质检小组',0,NULL,'24ff908ad3804ccdb6ee08289ed52d0f',NULL,NULL,NULL,NULL),('c8149486e96c4ac183068326737c2cff','测试小组',400,NULL,'5e7dd6deb9c547398562db9149f8fdf5',NULL,NULL,NULL,NULL),('d6f8a2fc4455400aa66a1cf5d2a08e6c','华南事业部',300,NULL,'79e63714d1264c03ba9246f88e78ce3f',NULL,NULL,NULL,NULL),('e969ca0b8658494295fc0d38f092e29c','CCWEB产品小组',0,NULL,'24ff908ad3804ccdb6ee08289ed52d0f',NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `hrm_department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hrm_department_employee`
--

DROP TABLE IF EXISTS `hrm_department_employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_department_employee` (
  `id` varchar(38) NOT NULL,
  `department_id` varchar(38) DEFAULT NULL,
  `employee_id` varchar(38) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_department_employee`
--

LOCK TABLES `hrm_department_employee` WRITE;
/*!40000 ALTER TABLE `hrm_department_employee` DISABLE KEYS */;
/*!40000 ALTER TABLE `hrm_department_employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hrm_department_job`
--

DROP TABLE IF EXISTS `hrm_department_job`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_department_job` (
  `id` varchar(38) NOT NULL,
  `job_name` varchar(160) DEFAULT NULL,
  `job_type_id` varchar(38) DEFAULT NULL,
  `start_time` datetime DEFAULT NULL,
  `end_time` datetime DEFAULT NULL,
  `des` varchar(45) DEFAULT NULL,
  `money_start` int(11) DEFAULT NULL,
  `money_end` int(11) DEFAULT NULL,
  `department_id` varchar(38) DEFAULT NULL,
  `job_num_start` int(11) DEFAULT NULL,
  `job_num_end` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_department_job`
--

LOCK TABLES `hrm_department_job` WRITE;
/*!40000 ALTER TABLE `hrm_department_job` DISABLE KEYS */;
/*!40000 ALTER TABLE `hrm_department_job` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hrm_department_job_item`
--

DROP TABLE IF EXISTS `hrm_department_job_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_department_job_item` (
  `id` varchar(38) NOT NULL,
  `item_type` int(11) DEFAULT NULL,
  `des` varchar(180) DEFAULT NULL,
  `is_necessary` varchar(45) DEFAULT NULL,
  `job_id` varchar(38) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_department_job_item`
--

LOCK TABLES `hrm_department_job_item` WRITE;
/*!40000 ALTER TABLE `hrm_department_job_item` DISABLE KEYS */;
/*!40000 ALTER TABLE `hrm_department_job_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hrm_department_kpi_template`
--

DROP TABLE IF EXISTS `hrm_department_kpi_template`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_department_kpi_template` (
  `id` varchar(38) NOT NULL,
  `pid` varchar(38) DEFAULT NULL,
  `item_name` varchar(38) DEFAULT NULL,
  `standard_score` int(11) DEFAULT NULL,
  `item_type` int(11) DEFAULT NULL COMMENT '按月，按周，按年',
  `is_delete` int(11) DEFAULT NULL,
  `department_id` varchar(38) DEFAULT NULL,
  `order_num` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_department_kpi_template`
--

LOCK TABLES `hrm_department_kpi_template` WRITE;
/*!40000 ALTER TABLE `hrm_department_kpi_template` DISABLE KEYS */;
/*!40000 ALTER TABLE `hrm_department_kpi_template` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hrm_employee`
--

DROP TABLE IF EXISTS `hrm_employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_employee` (
  `id` varchar(38) NOT NULL,
  `employee_name` varchar(16) DEFAULT NULL,
  `sex` int(6) DEFAULT NULL,
  `id_num` varchar(38) DEFAULT NULL,
  `emp_num` int(11) DEFAULT NULL,
  `marriage` int(11) DEFAULT NULL,
  `childrenNum` int(11) DEFAULT NULL,
  `in_time` datetime DEFAULT NULL,
  `phone_num` varchar(38) DEFAULT NULL,
  `phone_num2` varchar(38) DEFAULT NULL,
  `birthday` datetime DEFAULT NULL,
  `employee_state` int(11) DEFAULT NULL,
  `add_time` datetime DEFAULT NULL,
  `telphone` varchar(38) DEFAULT NULL,
  `salary` decimal(10,2) DEFAULT NULL,
  `emergency_name` varchar(16) DEFAULT NULL,
  `emergency_phone_num` varchar(38) DEFAULT NULL,
  `regular_time` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_employee`
--

LOCK TABLES `hrm_employee` WRITE;

UNLOCK TABLES;

--
-- Table structure for table `hrm_employee_education`
--

DROP TABLE IF EXISTS `hrm_employee_education`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_employee_education` (
  `id` varchar(38) NOT NULL,
  `start_time` datetime DEFAULT NULL,
  `end_time` datetime DEFAULT NULL,
  `school_name` varchar(88) DEFAULT NULL,
  `degree` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_employee_education`
--

LOCK TABLES `hrm_employee_education` WRITE;
/*!40000 ALTER TABLE `hrm_employee_education` DISABLE KEYS */;
/*!40000 ALTER TABLE `hrm_employee_education` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hrm_employee_education_certificate`
--

DROP TABLE IF EXISTS `hrm_employee_education_certificate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_employee_education_certificate` (
  `id` varchar(38) NOT NULL,
  `certificate_num` int(11) DEFAULT NULL,
  `certificate_name` varchar(88) DEFAULT NULL,
  `education_id` varchar(38) DEFAULT NULL,
  `employee_id` varchar(38) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_employee_education_certificate`
--

LOCK TABLES `hrm_employee_education_certificate` WRITE;
/*!40000 ALTER TABLE `hrm_employee_education_certificate` DISABLE KEYS */;
/*!40000 ALTER TABLE `hrm_employee_education_certificate` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hrm_employee_kpi`
--

DROP TABLE IF EXISTS `hrm_employee_kpi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_employee_kpi` (
  `id` varchar(38) NOT NULL,
  `employee_id` varchar(38) DEFAULT NULL,
  `kpi_template_id` varchar(38) DEFAULT NULL,
  `score` int(11) DEFAULT NULL,
  `des` varchar(580) DEFAULT NULL,
  `add_time` datetime DEFAULT NULL,
  `add_account_id` varchar(38) DEFAULT NULL,
  `batch_num` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_employee_kpi`
--

LOCK TABLES `hrm_employee_kpi` WRITE;
/*!40000 ALTER TABLE `hrm_employee_kpi` DISABLE KEYS */;
/*!40000 ALTER TABLE `hrm_employee_kpi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hrm_employee_transfer`
--

DROP TABLE IF EXISTS `hrm_employee_transfer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_employee_transfer` (
  `id` varchar(38) NOT NULL,
  `from_department_id` varchar(38) DEFAULT NULL,
  `to_department_id` varchar(38) DEFAULT NULL,
  `des` varchar(680) DEFAULT NULL,
  `target_employee_id` varchar(45) DEFAULT NULL,
  `add_account_id` varchar(45) DEFAULT NULL,
  `add_time` datetime DEFAULT NULL,
  `apply_time` datetime DEFAULT NULL,
  `from_department_manager_id` varchar(38) DEFAULT NULL,
  `to_department_manager_id` varchar(38) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_employee_transfer`
--

LOCK TABLES `hrm_employee_transfer` WRITE;
/*!40000 ALTER TABLE `hrm_employee_transfer` DISABLE KEYS */;
/*!40000 ALTER TABLE `hrm_employee_transfer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hrm_employee_work_experience`
--

DROP TABLE IF EXISTS `hrm_employee_work_experience`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_employee_work_experience` (
  `id` varchar(38) NOT NULL,
  `company_name` varchar(160) DEFAULT NULL,
  `start_time` datetime DEFAULT NULL,
  `end_time` datetime DEFAULT NULL,
  `job_name` varchar(160) DEFAULT NULL,
  `certifier` varchar(18) DEFAULT NULL,
  `certifier_phone` varchar(18) DEFAULT NULL,
  `employee_id` varchar(38) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_employee_work_experience`
--

LOCK TABLES `hrm_employee_work_experience` WRITE;
/*!40000 ALTER TABLE `hrm_employee_work_experience` DISABLE KEYS */;
/*!40000 ALTER TABLE `hrm_employee_work_experience` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hrm_interview`
--

DROP TABLE IF EXISTS `hrm_interview`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_interview` (
  `id` varchar(38) NOT NULL,
  `start_time` datetime DEFAULT NULL,
  `interviewer_id` varchar(38) DEFAULT NULL,
  `des` varchar(45) DEFAULT NULL,
  `pid` varchar(38) DEFAULT NULL,
  `target_job_id` varchar(38) DEFAULT NULL,
  `applicant` varchar(45) DEFAULT NULL,
  `applicant_phone` varchar(45) DEFAULT NULL,
  `money_start` datetime DEFAULT NULL,
  `money_end` datetime DEFAULT NULL,
  `is_finish` int(11) DEFAULT NULL,
  `is_access` int(11) DEFAULT NULL,
  `once_more` int(11) DEFAULT NULL,
  `resume_url` varchar(560) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_interview`
--

LOCK TABLES `hrm_interview` WRITE;
/*!40000 ALTER TABLE `hrm_interview` DISABLE KEYS */;
/*!40000 ALTER TABLE `hrm_interview` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hrm_question`
--

DROP TABLE IF EXISTS `hrm_question`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_question` (
  `id` varchar(38) NOT NULL,
  `title` varchar(580) DEFAULT NULL,
  `score` int(11) DEFAULT NULL,
  `question_type` int(11) DEFAULT NULL,
  `add_time` varchar(45) DEFAULT NULL,
  `add_account_id` varchar(38) DEFAULT NULL,
  `is_delete` int(11) DEFAULT NULL,
  `standard_answer` varchar(3800) DEFAULT NULL,
  `standard_answer_num` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_question`
--

LOCK TABLES `hrm_question` WRITE;
/*!40000 ALTER TABLE `hrm_question` DISABLE KEYS */;
/*!40000 ALTER TABLE `hrm_question` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hrm_test`
--

DROP TABLE IF EXISTS `hrm_test`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_test` (
  `id` varchar(38) NOT NULL,
  `test_name` varchar(180) DEFAULT NULL,
  `add_time` datetime DEFAULT NULL,
  `add_account_id` varchar(38) DEFAULT NULL,
  `test_begin_time` datetime DEFAULT NULL,
  `test_end_time` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_test`
--

LOCK TABLES `hrm_test` WRITE;
/*!40000 ALTER TABLE `hrm_test` DISABLE KEYS */;
/*!40000 ALTER TABLE `hrm_test` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hrm_test_employee`
--

DROP TABLE IF EXISTS `hrm_test_employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_test_employee` (
  `id` varchar(38) NOT NULL,
  `employee_id` varchar(38) DEFAULT NULL,
  `hrm_test_id` varchar(38) DEFAULT NULL,
  `person_start_time` datetime DEFAULT NULL,
  `person_end_time` datetime DEFAULT NULL,
  `score` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_test_employee`
--

LOCK TABLES `hrm_test_employee` WRITE;
/*!40000 ALTER TABLE `hrm_test_employee` DISABLE KEYS */;
/*!40000 ALTER TABLE `hrm_test_employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hrm_test_employee_answer`
--

DROP TABLE IF EXISTS `hrm_test_employee_answer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_test_employee_answer` (
  `id` varchar(38) NOT NULL,
  `employee_account_id` varchar(38) DEFAULT NULL,
  `test_id` varchar(38) DEFAULT NULL,
  `test_question_id` varchar(38) DEFAULT NULL,
  `employee_answer_num` int(11) DEFAULT NULL,
  `employee_answer` varchar(3800) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_test_employee_answer`
--

LOCK TABLES `hrm_test_employee_answer` WRITE;
/*!40000 ALTER TABLE `hrm_test_employee_answer` DISABLE KEYS */;
/*!40000 ALTER TABLE `hrm_test_employee_answer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hrm_test_question`
--

DROP TABLE IF EXISTS `hrm_test_question`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_test_question` (
  `id` varchar(38) NOT NULL,
  `question_id` varchar(38) DEFAULT NULL,
  `test_id` varchar(38) DEFAULT NULL,
  `order_num` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_test_question`
--

LOCK TABLES `hrm_test_question` WRITE;
/*!40000 ALTER TABLE `hrm_test_question` DISABLE KEYS */;
/*!40000 ALTER TABLE `hrm_test_question` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hrm_train`
--

DROP TABLE IF EXISTS `hrm_train`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_train` (
  `id` varchar(38) NOT NULL,
  `train_title` varchar(180) DEFAULT NULL,
  `des` varchar(3800) DEFAULT NULL,
  `begin_time` datetime DEFAULT NULL,
  `end_time` datetime DEFAULT NULL,
  `is_loop` int(11) DEFAULT NULL,
  `loop_type` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_train`
--

LOCK TABLES `hrm_train` WRITE;
/*!40000 ALTER TABLE `hrm_train` DISABLE KEYS */;
/*!40000 ALTER TABLE `hrm_train` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hrm_train_course`
--

DROP TABLE IF EXISTS `hrm_train_course`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_train_course` (
  `id` varchar(38) NOT NULL,
  `begin_time` datetime DEFAULT NULL,
  `end_time` datetime DEFAULT NULL,
  `des` varchar(3800) DEFAULT NULL,
  `meeting_room_id` varchar(38) DEFAULT NULL,
  `address` varchar(580) DEFAULT NULL,
  `is_external` int(11) DEFAULT NULL,
  `province_id` varchar(45) DEFAULT NULL,
  `city_id` varchar(45) DEFAULT NULL,
  `area_id` varchar(45) DEFAULT NULL,
  `is_end` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_train_course`
--

LOCK TABLES `hrm_train_course` WRITE;
/*!40000 ALTER TABLE `hrm_train_course` DISABLE KEYS */;
/*!40000 ALTER TABLE `hrm_train_course` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hrm_train_course_employee`
--

DROP TABLE IF EXISTS `hrm_train_course_employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hrm_train_course_employee` (
  `id` varchar(38) NOT NULL,
  `employee_id` varchar(38) DEFAULT NULL,
  `is_have_to` int(11) DEFAULT NULL,
  `hrm_train_course_id` varchar(38) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hrm_train_course_employee`
--

LOCK TABLES `hrm_train_course_employee` WRITE;
/*!40000 ALTER TABLE `hrm_train_course_employee` DISABLE KEYS */;
/*!40000 ALTER TABLE `hrm_train_course_employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mm_base`
--

DROP TABLE IF EXISTS `mm_base`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mm_base` (
  `id` varchar(38) NOT NULL,
  `des` varchar(3800) DEFAULT NULL,
  `price` decimal(10,2) DEFAULT NULL,
  `employee_id` varchar(45) DEFAULT NULL,
  `mm_name` varchar(45) DEFAULT NULL,
  `buy_time` datetime DEFAULT NULL,
  `add_time` datetime DEFAULT NULL,
  `add_account_id` varchar(38) DEFAULT NULL,
  `is_other` int(11) DEFAULT NULL,
  `is_error` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mm_base`
--

LOCK TABLES `mm_base` WRITE;
/*!40000 ALTER TABLE `mm_base` DISABLE KEYS */;
/*!40000 ALTER TABLE `mm_base` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mm_computer`
--

DROP TABLE IF EXISTS `mm_computer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mm_computer` (
  `id` varchar(38) NOT NULL,
  `computer_name` varchar(180) DEFAULT NULL,
  `CPU_name` varchar(80) DEFAULT NULL,
  `RAM_name` varchar(80) DEFAULT NULL,
  `CPU_num` varchar(80) DEFAULT NULL,
  `RAM_num` varchar(80) DEFAULT NULL,
  `disk_name` varchar(80) DEFAULT NULL,
  `disk_num` varchar(80) DEFAULT NULL,
  `is_laptop` int(11) DEFAULT NULL,
  `LCD_name` varchar(80) DEFAULT NULL,
  `LCD_num` varchar(80) DEFAULT NULL,
  `des` varchar(580) DEFAULT NULL,
  `employee_id` varchar(38) DEFAULT NULL,
  `price` int(11) DEFAULT NULL,
  `mm_base_id` varchar(38) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mm_computer`
--

LOCK TABLES `mm_computer` WRITE;
/*!40000 ALTER TABLE `mm_computer` DISABLE KEYS */;
/*!40000 ALTER TABLE `mm_computer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mm_meeting_room`
--

DROP TABLE IF EXISTS `mm_meeting_room`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mm_meeting_room` (
  `id` varchar(38) NOT NULL,
  `room_name` varchar(160) DEFAULT NULL,
  `des` varchar(580) DEFAULT NULL,
  `room_address` varchar(180) DEFAULT NULL,
  `mm_base_id` varchar(38) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mm_meeting_room`
--

LOCK TABLES `mm_meeting_room` WRITE;
/*!40000 ALTER TABLE `mm_meeting_room` DISABLE KEYS */;
/*!40000 ALTER TABLE `mm_meeting_room` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mm_other_template`
--

DROP TABLE IF EXISTS `mm_other_template`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mm_other_template` (
  `id` varchar(38) NOT NULL,
  `template_name` varchar(180) DEFAULT NULL,
  `des` varchar(3800) DEFAULT NULL,
  `mm_base_id` varchar(38) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mm_other_template`
--

LOCK TABLES `mm_other_template` WRITE;
/*!40000 ALTER TABLE `mm_other_template` DISABLE KEYS */;
/*!40000 ALTER TABLE `mm_other_template` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mm_other_template_item`
--

DROP TABLE IF EXISTS `mm_other_template_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mm_other_template_item` (
  `id` varchar(38) NOT NULL,
  `item_name` varchar(180) DEFAULT NULL,
  `item_type` int(11) DEFAULT NULL,
  `mm_template_id` varchar(38) DEFAULT NULL,
  `order_num` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mm_other_template_item`
--

LOCK TABLES `mm_other_template_item` WRITE;
/*!40000 ALTER TABLE `mm_other_template_item` DISABLE KEYS */;
/*!40000 ALTER TABLE `mm_other_template_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mm_other_template_item_value`
--

DROP TABLE IF EXISTS `mm_other_template_item_value`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mm_other_template_item_value` (
  `id` varchar(38) NOT NULL,
  `item_value` varchar(580) DEFAULT NULL,
  `template_item_id` varchar(38) DEFAULT NULL,
  `template_id` varchar(38) DEFAULT NULL,
  `add_account_id` varchar(38) DEFAULT NULL,
  `base_id` varchar(38) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mm_other_template_item_value`
--

LOCK TABLES `mm_other_template_item_value` WRITE;
/*!40000 ALTER TABLE `mm_other_template_item_value` DISABLE KEYS */;
/*!40000 ALTER TABLE `mm_other_template_item_value` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mm_printer`
--

DROP TABLE IF EXISTS `mm_printer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mm_printer` (
  `id` varchar(38) NOT NULL,
  `mm_base_id` varchar(38) DEFAULT NULL,
  `is_color` int(11) DEFAULT NULL,
  `ip_address` varchar(45) DEFAULT NULL,
  `drive_id` varchar(560) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mm_printer`
--

LOCK TABLES `mm_printer` WRITE;
/*!40000 ALTER TABLE `mm_printer` DISABLE KEYS */;
/*!40000 ALTER TABLE `mm_printer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mm_printer_drive`
--

DROP TABLE IF EXISTS `mm_printer_drive`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mm_printer_drive` (
  `id` varchar(38) NOT NULL,
  `drive_url` varchar(180) DEFAULT NULL,
  `drive_name` varchar(180) DEFAULT NULL,
  `add_time` datetime DEFAULT NULL,
  `add_account_id` varchar(38) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mm_printer_drive`
--

LOCK TABLES `mm_printer_drive` WRITE;
/*!40000 ALTER TABLE `mm_printer_drive` DISABLE KEYS */;
/*!40000 ALTER TABLE `mm_printer_drive` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sys_account`
--

DROP TABLE IF EXISTS `sys_account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sys_account` (
  `id` varchar(38) NOT NULL,
  `account_name` varchar(38) DEFAULT NULL,
  `pass_word` varchar(38) DEFAULT NULL,
  `employee_id` varchar(38) DEFAULT NULL,
  `add_time` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sys_account`
--

LOCK TABLES `sys_account` WRITE;
/*!40000 ALTER TABLE `sys_account` DISABLE KEYS */;
INSERT INTO `sys_account` VALUES ('07edca19e04249d58190e5276f63af7d','123','E90BFF256B234C150718119BD2BA5D13',NULL,'0001-01-01 00:00:00'),('0a3b6245cef442eba978efe0a5d32728','123','E90BFF256B234C150718119BD2BA5D13',NULL,'0001-01-01 00:00:00'),('0acf7a28bd354788b58a3d8ef7c0f942','ddd','08C5EDF04CA95F9CAF33B5CF78A3E5FF',NULL,'2017-03-31 11:40:24'),('12a7bd90f11b49da935108f3a7cd2e03','llll','5D9488E24936F023880D53171C695275',NULL,'2017-03-31 11:40:16'),('162ccf03a1834d8aba20d5a409d8ec05','bb','304873C70290CABCC2A16E472468B0D3',NULL,'2017-03-29 16:41:26'),('163e92737fc443249a287169ee691e20','cccc','BC38DB4C113048DAA6D46280FF9163A7',NULL,'2017-03-31 11:41:18'),('1911f90eebac402ca8a3135a7e293163','666','E67711E8FA53A4C05E27AB8B32B97E2E',NULL,'2017-03-31 11:40:32'),('1c5be2047cc54f4781a50f9c62d0e1b5','ttee','BC38DB4C113048DAA6D46280FF9163A7',NULL,'2017-03-31 11:42:51'),('21428718b09549fbb14ffbd8af9255ad','hhh','13A6CE267A6ED77B3C7DDFE60EC9B98A',NULL,'2017-03-31 11:40:00'),('236fafc64aec405bacdac09099b78070','BBB','8FA8608D05B19855761BFD206332861C',NULL,'2017-03-31 17:19:51'),('2d05780d24654644aa07e403ed473f5d','<<<','39C325D70C79A54FEBD8AC94BAC41AD9',NULL,'2017-03-31 11:42:10'),('2f4f97d41e2d446786edddd6fc3d27e2','aa','1AF2B31CB447F67FC0E63053A96A7B88',NULL,'2017-03-29 16:47:01'),('3332ab61be6e4e3bb19d599898d61242','vvv','9E025D20509BBA1BA900E7FE870642CE',NULL,'2017-03-29 21:31:34'),('36a79ad30603495ea389fbbff0f25483','1111','F69AA90B16D50015BC8FF132F94698CB',NULL,'2017-03-31 11:27:26'),('39da444a3058402e8582aad11de9d693','4444','43798473B1D438538002FABFCB4A2116',NULL,'2017-03-31 11:41:06'),('5339ee1ee7d54537b523a0561bae9ab6','8888','A7DC354DDF067477FD5FD72CE07A354D',NULL,'2017-03-31 11:40:58'),('552923a756764e76810dad3c36b1831e','vvvv','9B8AEBFC96395E0D88283727832B87D8',NULL,'2017-03-31 11:35:24'),('5ae1c0b5da214890aa882e7f99c2f511','2121','CA772298F49DBC9B7FA250D80BFAA372',NULL,'2017-03-31 11:39:45'),('65759b265d62418f930c2b5f16041fcc','66','83DBF5F52ECE5F129BB0519E0C78C0AB',NULL,'2017-03-29 21:31:55'),('6cdc87c335274e66a36ea2fc512797a5','444','5FD6D5038C784C1F6D4D1AE11E41DA91',NULL,'2017-03-31 19:11:55'),('7006b3ddb1ea4bfe903b917652554cdb','dd','62FAD9AC8E9EDD889C7EB06D7378E067',NULL,'2017-03-29 16:40:22'),('75bc16efed6c484f9d4bba8a356f74aa','999','70E256805280965002C59B8EE25575D9',NULL,'2017-03-31 11:43:31'),('8c4bcce64018405db1d2b0b9c8b81ba8','888','383E6DC86C8C205BB18035C12097462F',NULL,'2017-03-31 11:40:48'),('96d9e02b6f8b4561b523bb93f8863cfc','bb','304873C70290CABCC2A16E472468B0D3',NULL,'2017-03-29 16:49:14'),('98c04c4da05443c28cf8b1f10f3e8017','saas','F79729298D3F7B9D61DBC616F64252D6',NULL,'2017-03-31 11:43:17'),('9e93ab4fdda34bca9bf00ae171185de1','121212','7D67E6C83A46C45A7D552CDB18FFCD69',NULL,'2017-03-31 11:41:32'),('acb4b41af70d42f49eba506a31a9ee01','111','7F812ACD734469B4496D7675007A8CEF',NULL,'2017-03-29 16:56:39'),('afa3afd8d3634f07bd973964655d8f79','ooo','98B21D1ED6DF9C5CF9A559B35660F744',NULL,'2017-03-31 11:41:42'),('be0c3a7e5890446ba8888953b9d83b39','mmm','674ABA1A643D5963E30F8A455FF0B335',NULL,'2017-03-31 11:40:08'),('c1e646e6e38e48f9be64004df1d16dc8','hh','23139C43B9D11D5DB9BD895D3997B0D1',NULL,'2017-03-29 16:44:28'),('c5085b54563b44d9ae23c1b913109f1f','```','C61F5F4CE4315C8319A01CB8BD544E2A',NULL,'2017-03-31 11:41:52'),('cf5732df301e48bd955fea4d78765fb6','yy','F0D7CD384E7FA4B61D5E9188B4C1BE99',NULL,'2017-03-29 21:32:25'),('d19e43fd4d30436e80a059788f35b958','cc','8E57E5FAE3A55B1915B3F10120D2085F',NULL,'2017-03-29 16:41:55'),('d27bca1dba564fa1830591a3f33d231b','cc','8E57E5FAE3A55B1915B3F10120D2085F',NULL,'2017-03-29 16:42:26'),('d698716eebd545608b9ce7550e9181dd','asdf','70D56EF0205ACBC937492399524D6330',NULL,'2017-03-31 11:43:03'),('ea267fcfd17346df8b7cab037f98411e','1010','0673E74E7BE4CF244CD716F85959ACF7',NULL,'2017-03-31 11:43:44'),('efaeb5d1b8014b0cad2d5a06b0bf6729','aa','1AF2B31CB447F67FC0E63053A96A7B88',NULL,'2017-03-29 21:31:47'),('f23193a14d224e76a90fdd91178c0b42','ysl','123456',NULL,'2017-03-29 10:55:14'),('f27353c2acae4e09a1baf2700b1bb258','66','83DBF5F52ECE5F129BB0519E0C78C0AB',NULL,'2017-03-29 21:32:03'),('f369d1d9811343d99e99a31fe3eb4d72','1212','7D67E6C83A46C45A7D552CDB18FFCD69',NULL,'2017-03-31 11:39:29'),('f757c54c7b5f440d9e112563477603e4','dd','62FAD9AC8E9EDD889C7EB06D7378E067',NULL,'2017-03-29 16:40:11');
/*!40000 ALTER TABLE `sys_account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sys_account_role`
--

DROP TABLE IF EXISTS `sys_account_role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sys_account_role` (
  `id` varchar(38) NOT NULL,
  `account_id` varchar(38) DEFAULT NULL,
  `role_id` varchar(38) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sys_account_role`
--

LOCK TABLES `sys_account_role` WRITE;
/*!40000 ALTER TABLE `sys_account_role` DISABLE KEYS */;
INSERT INTO `sys_account_role` VALUES ('2f87bea5c83244f680bba53721a2bf09','236fafc64aec405bacdac09099b78070','100c29485f0b42e48a80f25405a08d1a'),('3255591e5a064b3698b47cbc40a7460e','236fafc64aec405bacdac09099b78070','a5953467506d41a989d73fba99fa718d'),('57c29338f23343ed89d3d6c75465c778','236fafc64aec405bacdac09099b78070','46d032bb46a1480a8c58b0c221ff7e75'),('9f3c66b276494499af4ec33db501c603','6cdc87c335274e66a36ea2fc512797a5','44a7a7fed5de4ccaa01af2246d291694'),('aafe4f2b0cf44ba0b82f7e16caf4c02e','236fafc64aec405bacdac09099b78070','46af690297b84a9ead8ba8d0ed87d22e');
/*!40000 ALTER TABLE `sys_account_role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sys_func`
--

DROP TABLE IF EXISTS `sys_func`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sys_func` (
  `id` varchar(38) NOT NULL,
  `func_name` varchar(38) DEFAULT NULL,
  `order_num` int(10) unsigned DEFAULT NULL,
  `pid` varchar(38) DEFAULT '0',
  `path` varchar(666) DEFAULT NULL,
  `des` varchar(666) DEFAULT NULL,
  `icon` varchar(38) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sys_func`
--

LOCK TABLES `sys_func` WRITE;
/*!40000 ALTER TABLE `sys_func` DISABLE KEYS */;
INSERT INTO `sys_func` VALUES ('2951e1887c244d11b23a0c39bf87ecdc','财务管理',400,'',NULL,NULL,'icon-caiwu'),('2af49e2f029546ccbf3f3b99e97e68ad','登录日志',200,'f9ab5e5b0d6240bbb99c04855b582d3f',NULL,NULL,'icon-78xitongdenglurizhi'),('447a6805194045b68382d25f85e5e075','异常日志',100,'f9ab5e5b0d6240bbb99c04855b582d3f',NULL,NULL,'icon-yichang'),('46dce2e4cf0144279be6876ee219cc57','角色管理',300,'653599f6ac2c46368421586a5e229664','/sys/role',NULL,'icon-jiaoseguanli1'),('474a1f6afeb84448b0ff9b8ab678b307','基础参数',50,'653599f6ac2c46368421586a5e229664','/sys/param',NULL,'icon-parameter'),('649785f6181b49b29535de0e67d409d8','帐号管理',200,'653599f6ac2c46368421586a5e229664','/sys/account',NULL,'icon-yuangong-fu'),('653599f6ac2c46368421586a5e229664','系统管理',100,'','1','1111','icon-xitongguanli'),('6990bb71f64a43aca42695f47cb9ac38','面试管理',200,'e95bc3b6864842a0996d66c6dbc157d5','200',NULL,'icon-mianshi'),('6a8aed2524be445492307d7bd4b3e5db','所有员工',300,'ade7028e9576406fbbf792bba5ec7805','/hrm/employee',NULL,NULL),('6f7b910fcda647b48f24599add1df18b','打印机管理',100,'d0e5d8b5d7d54f0ca7027f1ed1d67abd',NULL,NULL,'icon-dayinjin0101'),('96a4ec413b29436bab2db1f92f4be43b','部门管理',50,'e95bc3b6864842a0996d66c6dbc157d5','/hrm/department',NULL,'icon-48copy9-copy'),('a1fad3582b2b429b95ab5a3d43d8ccc7','会议室管理',300,'d0e5d8b5d7d54f0ca7027f1ed1d67abd',NULL,NULL,'icon-huiyishi01'),('a8df1956473b4010a9a53832d98904f2','培训管理',300,'e95bc3b6864842a0996d66c6dbc157d5',NULL,NULL,'icon-icon'),('ade7028e9576406fbbf792bba5ec7805','员工管理',100,'e95bc3b6864842a0996d66c6dbc157d5','/hrm/employee',NULL,'icon-yggl'),('b37597d49c864feb85d3f7229439d930','其他物资管理',500,'d0e5d8b5d7d54f0ca7027f1ed1d67abd',NULL,NULL,'icon-ic11'),('b687518f709a475e90331c968c8b0cea','按角色查找员工',200,'ade7028e9576406fbbf792bba5ec7805',NULL,NULL,NULL),('b6d63c76b8cb42e6b806c0aca8a54913','投影仪',0,'d0e5d8b5d7d54f0ca7027f1ed1d67abd',NULL,NULL,'icon-projector'),('bd7bf33bd7344352a0b899b7b87fd250','按部门查找员工',100,'ade7028e9576406fbbf792bba5ec7805',NULL,NULL,NULL),('d0e5d8b5d7d54f0ca7027f1ed1d67abd','物资管理',300,'','300','11','icon-shebeishebeiguanli'),('d35f815121574d968f55f976ca946897','权限管理',100,'653599f6ac2c46368421586a5e229664','/sys/func',NULL,'icon-iconfontzuzhijiagou'),('e95bc3b6864842a0996d66c6dbc157d5','人力资源',200,'','2',NULL,'icon-renli'),('f2b143947b4742f6a77076cf5532e966','电脑管理',200,'d0e5d8b5d7d54f0ca7027f1ed1d67abd',NULL,NULL,'icon-diannao'),('f9ab5e5b0d6240bbb99c04855b582d3f','系统日志',400,'653599f6ac2c46368421586a5e229664',NULL,NULL,'icon-yichangchakan');
/*!40000 ALTER TABLE `sys_func` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sys_log`
--

DROP TABLE IF EXISTS `sys_log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sys_log` (
  `id` varchar(38) NOT NULL,
  `log_title` varchar(180) DEFAULT NULL,
  `log_detail` varchar(3800) DEFAULT NULL,
  `account_id` varchar(38) DEFAULT NULL,
  `source_ip` varchar(45) DEFAULT NULL,
  `add_time` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sys_log`
--

LOCK TABLES `sys_log` WRITE;
/*!40000 ALTER TABLE `sys_log` DISABLE KEYS */;
/*!40000 ALTER TABLE `sys_log` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sys_msg`
--

DROP TABLE IF EXISTS `sys_msg`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sys_msg` (
  `id` varchar(38) NOT NULL,
  `msg_title` varchar(180) DEFAULT NULL,
  `msg_content` varchar(3800) DEFAULT NULL,
  `from_id` varchar(38) DEFAULT NULL,
  `to_id` varchar(38) DEFAULT NULL,
  `is_viewd` int(11) DEFAULT NULL,
  `view_time` datetime DEFAULT NULL,
  `send_time` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sys_msg`
--

LOCK TABLES `sys_msg` WRITE;
/*!40000 ALTER TABLE `sys_msg` DISABLE KEYS */;
/*!40000 ALTER TABLE `sys_msg` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sys_role`
--

DROP TABLE IF EXISTS `sys_role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sys_role` (
  `id` varchar(38) NOT NULL,
  `role_name` varchar(38) DEFAULT NULL,
  `order_num` int(10) unsigned DEFAULT NULL,
  `des` varchar(666) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sys_role`
--

LOCK TABLES `sys_role` WRITE;
/*!40000 ALTER TABLE `sys_role` DISABLE KEYS */;
INSERT INTO `sys_role` VALUES ('03054f5a8c7f4d1b80597a8a1c806e62','vvv',1,'v'),('100c29485f0b42e48a80f25405a08d1a','看看看',12,'阿斯蒂芬'),('3e3196c9be56410698c4e4c12f2031b0','他他他',12,'12'),('44a7a7fed5de4ccaa01af2246d291694','bbb',2,'2'),('46af690297b84a9ead8ba8d0ed87d22e','666',6,'6'),('46d032bb46a1480a8c58b0c221ff7e75','123',1,'1'),('4a725649573b4001980f745cd583866e','111',0,NULL),('91fa3eff0f204c68bd9b89891c3da6dc','得到的',100,''),('a5953467506d41a989d73fba99fa718d','222333',0,'123'),('ce8cf48f25ae41e2a6b605f51d9f176d','bbb阿斯蒂芬',12,'斑斑驳驳');
/*!40000 ALTER TABLE `sys_role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sys_role_func`
--

DROP TABLE IF EXISTS `sys_role_func`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sys_role_func` (
  `id` varchar(38) NOT NULL,
  `role_id` varchar(38) DEFAULT NULL,
  `func_id` varchar(38) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sys_role_func`
--

LOCK TABLES `sys_role_func` WRITE;
/*!40000 ALTER TABLE `sys_role_func` DISABLE KEYS */;
INSERT INTO `sys_role_func` VALUES ('014609f4a1274e9c8850c591815ac464','03054f5a8c7f4d1b80597a8a1c806e62','a1fad3582b2b429b95ab5a3d43d8ccc7'),('71b8d0451caa4117a4f5e71047604044','03054f5a8c7f4d1b80597a8a1c806e62','b37597d49c864feb85d3f7229439d930'),('7d8dcec3233c4eacac662081608f1e40','03054f5a8c7f4d1b80597a8a1c806e62','2951e1887c244d11b23a0c39bf87ecdc'),('98f246b7c13a47679745a637b031ac13','a5953467506d41a989d73fba99fa718d','b37597d49c864feb85d3f7229439d930'),('c15149769f8b4d67a53f3efb7874a983','a5953467506d41a989d73fba99fa718d','2951e1887c244d11b23a0c39bf87ecdc'),('ed003daf805141b6b91092b3a7fd55b4','4a725649573b4001980f745cd583866e','2951e1887c244d11b23a0c39bf87ecdc');
/*!40000 ALTER TABLE `sys_role_func` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-04-21 15:36:50
