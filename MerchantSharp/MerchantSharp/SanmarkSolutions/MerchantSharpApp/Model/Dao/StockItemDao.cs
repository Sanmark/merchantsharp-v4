﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantSharp.SanmarkSolutions.MerchantSharpApp.Model.Dao {
	class StockItemDao : BaseDao, IDao {

		private static StockItemDao dao = null;

		private StockItemDao() {
			base.TableName = "stock_item";
		}

		public static StockItemDao getInstance() {
			try {
				if(dao == null) {
					dao = new StockItemDao();
					dao.initializeTable();
				}
			} catch(Exception) {
			}
			return dao;
		}


		public int add(Entities.Entity entity) {
			return base.addEntity(entity);
		}

		public bool del(Entities.Entity entity) {
			throw new NotImplementedException();
		}

		public List<Entities.Entity> get(Entities.Entity entity) {
			return base.getEntity(entity);
		}

		public int upd(Entities.Entity entity) {
			return base.updEntity(entity);
		}
	}
}
