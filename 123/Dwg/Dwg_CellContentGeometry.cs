//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_CellContentGeometry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_CellContentGeometry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_CellContentGeometry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_CellContentGeometry() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LibreDWGPINVOKE.delete_Dwg_CellContentGeometry(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Bitcode_3BD dist_top_left {
    set {
      LibreDWGPINVOKE.Dwg_CellContentGeometry_dist_top_left_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_CellContentGeometry_dist_top_left_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD dist_center {
    set {
      LibreDWGPINVOKE.Dwg_CellContentGeometry_dist_center_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_CellContentGeometry_dist_center_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public double content_width {
    set {
      LibreDWGPINVOKE.Dwg_CellContentGeometry_content_width_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_CellContentGeometry_content_width_get(swigCPtr);
      return ret;
    } 
  }

  public double content_height {
    set {
      LibreDWGPINVOKE.Dwg_CellContentGeometry_content_height_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_CellContentGeometry_content_height_get(swigCPtr);
      return ret;
    } 
  }

  public double width {
    set {
      LibreDWGPINVOKE.Dwg_CellContentGeometry_width_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_CellContentGeometry_width_get(swigCPtr);
      return ret;
    } 
  }

  public double height {
    set {
      LibreDWGPINVOKE.Dwg_CellContentGeometry_height_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_CellContentGeometry_height_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown {
    set {
      LibreDWGPINVOKE.Dwg_CellContentGeometry_unknown_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_CellContentGeometry_unknown_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_TableCell cell_parent {
    set {
      LibreDWGPINVOKE.Dwg_CellContentGeometry_cell_parent_set(swigCPtr, Dwg_TableCell.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_CellContentGeometry_cell_parent_get(swigCPtr);
      Dwg_TableCell ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_TableCell(cPtr, false);
      return ret;
    } 
  }

  public Dwg_TABLEGEOMETRY_Cell geom_parent {
    set {
      LibreDWGPINVOKE.Dwg_CellContentGeometry_geom_parent_set(swigCPtr, Dwg_TABLEGEOMETRY_Cell.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_CellContentGeometry_geom_parent_get(swigCPtr);
      Dwg_TABLEGEOMETRY_Cell ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_TABLEGEOMETRY_Cell(cPtr, false);
      return ret;
    } 
  }

  public Dwg_CellContentGeometry() : this(LibreDWGPINVOKE.new_Dwg_CellContentGeometry(), true) {
  }

}
