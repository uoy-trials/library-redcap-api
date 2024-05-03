﻿using System.ComponentModel.DataAnnotations;

namespace RedcapApi.Models
{
    /// <summary>
    /// Specifies the format of data
    /// 
    /// Format, 0 = json
    /// Format, 1 = csv [default]
    /// Format, 2 = xml 
    /// </summary>
    /// 
    public enum RedcapFormat
    {

        /// <summary>
        /// Default Javascript Notation
        /// </summary>
        /// 
        [Display(Name = "json")]
        json = 0,
        /// <summary>
        /// Comma Seperated Values
        /// </summary>
        /// 
        [Display(Name = "csv")]

        csv = 1,
        /// <summary>
        /// Extensible Markup Language
        /// </summary>
        /// 
        [Display(Name = "xml")]
        xml = 2
    }
}
