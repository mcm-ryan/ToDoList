import React, { Component } from "react";
import axios from "axios";
import { Table } from "antd";

export class ToDoList extends Component {
  constructor(props) {
    super(props);
    this.state = {
      ToDoList: [],  
      loading: true,
    };
  }

  componentDidMount() {
    this.populateToDoList();
  }

  populateToDoList() {
    axios
      .get("https://localhost:7036/api/ToDoList/GetToDoList")
      .then((result) => {
        this.setState({ ToDoList: result.data, loading: false });
      })
      .catch((error) => {
        console.error("Error fetching data:", error);
        this.setState({ loading: false });
      });
  }

  render() {
    const columns = [
      {
        title: "Title",
        dataIndex: "title", 
        key: "title",
        render: (text) => <a>{text}</a>,
      },
      {
        title: "Date Created",
        dataIndex: "createdDate",  
        key: "createdDate",
      },
    ];

    const rowSelection = {
      onChange: (selectedRowKeys, selectedRows) => {
        console.log(`selectedRowKeys: ${selectedRowKeys}`, "selectedRows: ", selectedRows);
      },
      getCheckboxProps: (record) => ({
        disabled: record.title === "Disabled User", 
        name: record.title,
      }),
    };

    return (
      <Table
        rowSelection={rowSelection}
        columns={columns}
        dataSource={this.state.ToDoList} 
        loading={this.state.loading} 
        rowKey="id" 
      />
    );
  }
}
