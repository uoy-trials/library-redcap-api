﻿using System.ComponentModel.DataAnnotations;

namespace RedcapApi.Models
{
    /// <summary>
    /// Redcap Content Model
    /// </summary>
    public enum Content
    {
        /// <summary>
        /// Log
        /// </summary>
        [Display(Name ="log")]
        Log,
        /// <summary>
        /// User-Mapping
        /// </summary>
        [Display(Name = "userDagMapping")]
        UserDagMapping,
        /// <summary>
        /// Dag Content
        /// </summary>
        [Display(Name = "dag")]
        Dag,
        /// <summary>
        /// Arm Content
        /// </summary>
        /// 
        [Display(Name = "arm")]
        Arm,
        /// <summary>
        /// Event Content
        /// </summary>
        /// 
        [Display(Name = "event")]
        Event,
        /// <summary>
        /// Export Field Names Content
        /// </summary>
        /// 
        [Display(Name = "exportFieldNames")]
        ExportFieldNames,
        /// <summary>
        /// File Content
        /// </summary>
        /// 
        [Display(Name = "file")]
        File,

        /// <summary>
        /// File Repository
        /// </summary>
        /// 
        [Display(Name ="fileRepository")]
        FileRepository,

        /// <summary>
        /// Meta Data Content
        /// </summary>
        /// 
        [Display(Name = "metadata")]
        MetaData,
        /// <summary>
        /// Instrument Content
        /// </summary>
        /// 
        [Display(Name = "instrument")]
        Instrument,
        /// <summary>
        /// Pdf Content
        /// </summary>
        /// 
        [Display(Name = "pdf")]
        Pdf,
        /// <summary>
        /// Form Event Mapping Content
        /// </summary>
        /// 
        [Display(Name = "formEventMapping")]
        FormEventMapping,
        /// <summary>
        /// Project Content
        /// </summary>
        /// 
        [Display(Name = "project")]
        Project,
        /// <summary>
        /// Project Settings Content
        /// </summary>
        /// 
        [Display(Name = "project_settings")]
        ProjectSettings,
        /// <summary>
        /// Project Xml Content
        /// </summary>
        /// 
        [Display(Name = "project_xml")]
        ProjectXml,
        /// <summary>
        /// Record Content
        /// </summary>
        /// 
        [Display(Name = "record")]
        Record,
        /// <summary>
        /// Generate Next Record Name Content
        /// </summary>
        /// 
        [Display(Name = "generateNextRecordName")]
        GenerateNextRecordName,
        /// <summary>
        /// Repeating Forms Events Content
        /// </summary>
        /// 
        [Display(Name = "repeatingFormsEvents")]
        RepeatingFormsEvents,
        /// <summary>
        /// Report Content
        /// </summary>
        /// 
        [Display(Name = "report")]
        Report,
        /// <summary>
        /// Version Content
        /// </summary>
        /// 
        [Display(Name = "version")]
        Version,
        /// <summary>
        /// Survey Link Content
        /// </summary>
        /// 
        [Display(Name = "surveyLink")]
        SurveyLink,
        /// <summary>
        /// Participant List Content
        /// </summary>
        /// 
        [Display(Name = "participantList")]
        ParticipantList,
        /// <summary>
        /// Survey Queue Link Content
        /// </summary>
        /// 
        [Display(Name = "surveyQueueLink")]
        SurveyQueueLink,
        /// <summary>
        /// Survey Return Code Content
        /// </summary>
        /// 
        [Display(Name = "surveyReturnCode")]
        SurveyReturnCode,
        /// <summary>
        /// User Content
        /// </summary>
        /// 
        [Display(Name = "user")]
        User,

        /// <summary>
        /// User Role
        /// </summary>
        [Display(Name ="userRole")]
        UserRole,
        /// <summary>
        /// User Role Mapping
        /// </summary>
        [Display(Name = "userRoleMapping")]
        UserRoleMapping


    }
}
