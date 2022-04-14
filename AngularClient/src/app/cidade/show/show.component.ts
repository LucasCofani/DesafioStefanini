import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-cidade-show',
  templateUrl: './show.component.html',
  styleUrls: ['./show.component.css']
})
export class ShowCidadeComponent implements OnInit {

  constructor(private service:SharedService) { }

  CidadeList:any=[];
  ModalTitle:string="";
  cid:any;
  action:any;
  enableFields:boolean=false;
  Disabled:boolean=false;

  ngOnInit(): void {
    this.refreshCidade();
  }

  refreshCidade(){
    this.service.getAllCidade().subscribe( data =>{
      this.CidadeList=data.info;
    });
  }
  
  closeModal(){
    this.enableFields=false;
    this.refreshCidade();
  }
  addClick(){
    this.cid={
      id:0,
      nome:"",
      uf:""
    };
    this.action="add";
    this.ModalTitle="Adicionando nova cidade";
    this.enableFields=true;
    this.Disabled=false;
  }

  editClick(item:any){
    this.cid = item;
    this.action="edit";
    this.ModalTitle="Editando cidade";
    this.enableFields=true;
    this.Disabled=false;
  }
  deleteClick(item:any){
    this.ModalTitle="Deletando cidade";
    this.action="del";
    this.enableFields=true;
    this.cid = item;
    this.Disabled=true;
  }

}
