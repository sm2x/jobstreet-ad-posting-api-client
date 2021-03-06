﻿using System;
using System.Linq;
using JobStreet.AdPostingApi.Client.Models;

namespace JobStreet.AdPostingApi.Client.Tests.Framework
{
    public class AdvertisementModelBuilder : AdvertisementModelBuilder<Advertisement>
    {
        public AdvertisementModelBuilder(IBuilderInitializer initializer = null) : base(initializer)
        {
            initializer?.Initialize(this);
        }
    }

    public class AdvertisementModelBuilder<TAdvertisement> where TAdvertisement : Advertisement, new()
    {
        #region CENTRALISED CODE START
        private string _agentId;
        private string _advertiserId;
        private string _jobTitle;
        private int?[] _employmentType;
        private int?[] _locationId;
        private string _locationArea;
        private decimal _salaryMinimum;
        private decimal _salaryMaximum;
        private int? _salaryCurrencyCode;
        private bool _salaryDisplay;
        private string _jobDescription;
        private int? _jobSpecialization;
        private int? _jobRole;
        private int?[] _educationLevel;
        private int? _positionLevel;
        private int? _yearOfExperience;
        private int?[] _site;
        private DateTime _postingDate;
        private string[] _standOutBullet;
        private string _creationId;
        private string _applicationFormUrl;
        private string _applicationEmail;
        private string _companyOverview;
        private string _jobReference;
        #endregion CENTRALISED CODE END

        #region JOBSTREET CODE START
        private int?[] _fieldOfStudy;
        private string[] _skill;
        private bool _blindAd;
        private int?[] _language;
        private int? _templateId;
        #endregion JOBSTREET CODE END

        protected AdvertisementModelBuilder(IBuilderInitializer initializer = null)
        {
            initializer?.Initialize(this);
        }

        public AdvertisementModelBuilder<TAdvertisement> WithAdvertiserId(string advertiserId)
        {
            this._advertiserId = advertiserId;
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithAgentId(string agentId)
        {
            this._agentId = agentId;
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithJobTitle(string jobTitle)
        {
            this._jobTitle = jobTitle;
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithEmploymentType(int?[] employmentType)
        {
            this._employmentType = employmentType;
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithLocationId(int?[] locationId)
        {
            this._locationId = locationId;
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithLocationArea(string locationArea)
        {
            this._locationArea = locationArea;
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithSalaryMinimum(decimal minimum)
        {
            this._salaryMinimum = minimum;
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithSalaryMaximum(decimal maximum)
        {
            this._salaryMaximum = maximum;
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithSalaryCurrencyCode(int? currencyCode)
        {
            this._salaryCurrencyCode = currencyCode;
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithSalaryDisplay(bool display)
        {
            this._salaryDisplay = display;
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithJobDescription(string jobDescription)
        {
            this._jobDescription = jobDescription;
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithJobSpecialization(int? jobSpecialization)
        {
            this._jobSpecialization = jobSpecialization;
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithJobRole(int? jobRole)
        {
            this._jobRole = jobRole;
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithEducationLevel(int?[] educationLevel)
        {
            this._educationLevel = educationLevel; 
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithPositionLevel(int? positionLevel)
        {
            this._positionLevel = positionLevel;
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithYearOfExperience(int? yearOfExperience)
        {
            this._yearOfExperience = yearOfExperience;
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithSite(int?[] site)
        {
            this._site = site; 
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithPostingDate(DateTime postingDate)
        {
            this._postingDate = postingDate;

            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithStandOutBullet(params string[] standOutBullet)
        {
            this._standOutBullet = standOutBullet?.ToArray();
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithRequestCreationId(string creationId)
        {
            this._creationId = creationId;
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithApplicationFormUrl(string applicationFormUrl)
        {
            this._applicationFormUrl = applicationFormUrl;
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithApplicationEmail(string applicationEmail)
        {
            this._applicationEmail = applicationEmail;
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithCompanyOverview(string companyOverview)
        {
            this._companyOverview = companyOverview;
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithJobReference(string jobReference)
        {
            this._jobReference = jobReference;
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithFieldOfStudy(int?[] fieldOfStudy)
        {
            this._fieldOfStudy = fieldOfStudy; 
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithSkill(string[] skill)
        {
            this._skill = skill; 
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithBlindAd(bool blindAd)
        {
            this._blindAd = blindAd;
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithLanguage(int?[] language)
        {
            this._language = language;
            return this;
        }

        public AdvertisementModelBuilder<TAdvertisement> WithTemplateId(int? id)
        {
            this._templateId = id;
            return this;
        }


        public virtual TAdvertisement Build()
        {
            return new TAdvertisement
            {
                ThirdParties = this._advertiserId == null && this._agentId == null
                    ? null
                    : new ThirdParties { AdvertiserId = this._advertiserId, AgentId = this._agentId },
                JobTitle = this._jobTitle,
                EmploymentType = this._employmentType,
                Salary = new Models.JobStreet.SalaryModel
                {
                    Minimum = this._salaryMinimum,
                    Maximum = this._salaryMaximum,
                    CurrencyCode = this._salaryCurrencyCode,
                    Display = this._salaryDisplay
                },
                Location = new Models.JobStreet.LocationModel
                {
                    Id = this._locationId,
                    Area = this._locationArea
                },
                JobDescription = this._jobDescription,
                JobSpecialization = this._jobSpecialization,
                JobRole = this._jobRole,
                EducationLevel = this._educationLevel,
                PositionLevel = this._positionLevel,
                YearOfExperience = this._yearOfExperience,
                Site = this._site,
                PostingDate = this._postingDate,
                StandOutBullet = this._standOutBullet?.ToArray(),
                CreationId = this._creationId,
                ApplicationFormUrl = this._applicationFormUrl,
                ApplicationEmail = this._applicationEmail,
                CompanyOverview = this._companyOverview,
                JobReference = this._jobReference,
                FieldOfStudy = this._fieldOfStudy,
                Skill = this._skill,
                BlindAd = this._blindAd,
                Language = this._language,
                TemplateId = this._templateId
            };
        }
    }
}