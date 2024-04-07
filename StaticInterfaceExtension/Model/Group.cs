﻿using StaticInterfaceExtension.Model;
using StaticInterfaceExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace StaticInterfaceExtension.Model
{
    public class Group
    {
        static int GroupCount=0;
        public int GroupId{  get; set; }
        public string GroupName {  get; set; }
        static Group[] Groups {  get; set; }=new Group[0];
        Student[] Students { get; set; }
        public Group(string groupName)
        {
            GroupCount++;
            GroupName=groupName;
            GroupId = GroupCount;
            Students = new Student[0];

        }
        public void GetGroupInfo()
        {
            Console.WriteLine($"Group Id: {GroupId}, Group Name: {GroupName}");
        }
        public void AddStudent(Student student)
        {
            int newLength = Students.Length + 1; 
            Student[] newStudents = new Student[newLength]; 
            for (int i = 0; i < Students.Length; i++)
            {
                newStudents[i] = Students[i];
            }
            newStudents[newLength - 1] = student;
            Students = newStudents;
        }
        public Student GetStudent(int id)
        {
            foreach(var student in Students) { 
            if(student.Id==id)
                    return student;
            } return null;
        }
        public void ShowStudent()
        {
            foreach(var student in Students)
            {
                Console.WriteLine(student.GetInfo);
            }
        }
        public override string ToString()
        {
            return ($"Group Id: {GroupId}, Group Name: {GroupName}, " +
                $"Number Students: {Students.Length}");
        }
        public static void AddGroup(Group group)
        {
            int newLength = Groups.Length + 1; 
            Group[] newGroups = new Group[newLength]; 
            for (int i = 0; i < Groups.Length; i++)
            {
                newGroups[i] = Groups[i];
            }
            newGroups[newLength - 1] = group;
            Groups = newGroups;
        }
        public static void RemoveGroup(int id)
        {
            if (id < Groups.Length)
            {
                Groups[id] = null;
            }
            else
            {
                Console.WriteLine("Bele bir slot movcut deyil");
            }
        }
       
        public static Group GetGroup(int id)
        {
            foreach (var group in Groups)
            {
                if (group.GroupId == id)
                    return group;
            }
            return null;
        }
    }
}




















