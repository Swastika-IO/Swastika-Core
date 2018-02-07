﻿using System;
using Swastika.Domain.Data.ViewModels;
using Microsoft.EntityFrameworkCore.Storage;
using Newtonsoft.Json;
using Swastika.Cms.Lib.Models.Cms;
using Swastika.Domain.Core.ViewModels;
using System.Linq.Expressions;

namespace Swastika.Cms.Lib.ViewModels.BackEnd
{
    public class BEMediaViewModel
        : ViewModelBase<SiocCmsContext, SiocMedia, BEMediaViewModel>
    {
        #region Properties
        #region Models
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("extension")]
        public string Extension { get; set; }
        [JsonProperty("fileFolder")]
        public string FileFolder { get; set; }
        [JsonProperty("fileName")]
        public string FileName { get; set; }
        [JsonProperty("fileType")]
        public string FileType { get; set; }
        [JsonProperty("createdDateTime")]
        public DateTime CreatedDateTime { get; set; }
        [JsonProperty("lastModified")]
        public DateTime? LastModified { get; set; }
        [JsonProperty("modifiedBy")]
        public string ModifiedBy { get; set; }
        #endregion

        #region Views

        #endregion

        #endregion

        #region Contructors

        public BEMediaViewModel() : base()
        {
        }

        public BEMediaViewModel(SiocMedia model, SiocCmsContext _context = null, IDbContextTransaction _transaction = null) 
            : base(model, _context, _transaction)
        {
        }

        #endregion

        #region Overrides

        #endregion

        #region Expands
       
        #endregion

    }
}
