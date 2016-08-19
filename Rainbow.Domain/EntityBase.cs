﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow.Domain
{
    /// <summary>
    /// The base class for domain entities.
    /// </summary>
    public abstract class EntityBase : IValidatable
    {
        /// <summary>
        /// The validation errors
        /// </summary>
        private ValidationErrors _validationErrors;

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        /// <value>
        /// The ID.
        /// </value>
        public Guid ID { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance is valid.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is valid; otherwise, <c>false</c>.
        /// </value>
        public virtual bool IsValid
        {
            get
            {
                _validationErrors.Clear();
                Validate();
                return ValidationErrors.Items.Count == 0;
            }
        }

        /// <summary>
        /// Gets the validation errors.
        /// </summary>
        /// <value>
        /// The validation errors.
        /// </value>
        public virtual ValidationErrors ValidationErrors
        {
            get
            {
                return _validationErrors;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityBase" /> class.
        /// </summary>
        protected EntityBase()
        {
            _validationErrors = new ValidationErrors();
        }

        /// <summary>
        /// Validates this instance.
        /// </summary>
        protected virtual void Validate() { }
    }
}
