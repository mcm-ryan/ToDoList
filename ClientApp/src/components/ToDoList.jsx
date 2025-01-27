import React, { Component, useState } from "react";
import axios from "axios";
import { Divider, Radio, Table } from "antd";

export class ToDoList extends Component {
  constructor(props) {
    super(props);
    this.state = {
      ToDoList: [],
      loading: true,
    };
  }

  populateTripsData() {
    axios
      .get("https://localhost:7036/api/ToDoList/GetToDoList")
      .then((result) => {
        const response = result.data;
        this.setState({ ToDoList: response, loading: false });
      });
  }

  render() {
    const [selectionType, setSelectionType] =
      (useState < "checkbox") | ("radio" > "checkbox");

    const columns = [
      {
        title: "Title",
        dataIndex: "name",
        render: (text) => <a>{text}</a>,
      },
      {
        title: "Date Created",
        dataIndex: "age",
      },
    ];

    // rowSelection object indicates the need for row selection
    const rowSelection = {
      onChange: (selectedRowKeys, selectedRows) => {
        console.log(
          `selectedRowKeys: ${selectedRowKeys}`,
          "selectedRows: ",
          selectedRows
        );
      },
      getCheckboxProps: (record) => ({
        disabled: record.name === "Disabled User", // Column configuration not to be checked
        name: record.name,
      }),
    };

    return (
      <div>
        <Radio.Group
          onChange={(e) => setSelectionType(e.target.value)}
          value={selectionType}
        >
          <Radio value="checkbox">Checkbox</Radio>
          <Radio value="radio">radio</Radio>
        </Radio.Group>
        <Divider />
        <Table
          rowSelection={{ type: selectionType, ...rowSelection }}
          columns={columns}
          dataSource={this.state}
        />
      </div>
    );
  }
}
