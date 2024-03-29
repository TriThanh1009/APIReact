/* eslint-disable no-undef */
/* "parser": "@babel/eslint-parser" */
import React, { useState } from 'react';
import { CustomerModel } from './Model/CustomerModel.ts';

const useEmployeeSearch = (apiUrl) => {
  const [keyword, setKeyword] = useState('')
  const [employees, setEmployees] = useState([]);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState(null);

  const getEmployeePaging = async ({ keyword, pageIndex, pageSize }) => {
    setLoading(true);
    setError(null);

    let url = `${apiUrl}/Employee/paging?PageIndex=${pageIndex}&PageSize=${pageSize}`;
    if (keyword && keyword !== '') {
      url = `${apiUrl}/Employee/paging?Keyword=${encodeURIComponent(keyword)}&PageIndex=${pageIndex}&PageSize=${pageSize}`;
    }


    try {
      const response = await fetch(url);
      if (!response.ok) {
        throw new Error('');
      }
      const data = await response.json();
      setEmployees(data);
    } catch (error) {
      setError(' ' + error.message);
    } finally {
      setLoading(false);
    }
  };

  const handleSearch = () => {
    getEmployeePaging(1, 10); 
  };

  return (
    <div>
      <input
        type="text"
        value={keyword}
        onChange={(e) => setKeyword(e.target.value)}
        placeholder="Search"
      />
      <button onClick={handleSearch} disabled={loading}>
        Tìm kiếm
      </button>

      {loading && <div>Đang tải...</div>}
      {error && <div>{error}</div>}
      <ul>
        {employees.map((employee) => (
          <li key={employee.id}>{employee.name}</li> // if keyword = '', this will get all data ( get all customer ), and if keyword has data, this will get the same data with keyword (search)
        ))}
      </ul>
    </div>
  )
}
export default MyComponent;