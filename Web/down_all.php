<?php 
 function dirZip($resource,$dir) { 
    if(filetype($dir) === 'dir') {
      clearstatcache(); 

      if($fp = @opendir($dir)) { 
        while(false !== ($ftmp = readdir($fp))){ 
          if(($ftmp !== ".") && ($ftmp !== "..") && ($ftmp !== ""))
          { 
            if(filetype($dir.'/'.$ftmp) === 'dir') { 
              clearstatcache();   

              // 디렉토리이면 생성하기 
              $resource->addEmptyDir($dir.'/'.$ftmp); 
              set_time_limit(0);   

              dirZip($resource,$dir.'/'.$ftmp); 
            } else { 

              // 파일이면 파일 압축하기 
              $resource->addFile($dir.'/'.$ftmp); 
            } 
          } 
        } 
      } 
      if(is_resource($fp)){ 
        closedir($fp);
      } 
    } else { 
      // 파일이면 파일 압축하기 
      $resource->addFile($dir); 
    } 
 } // end func 


 // 압축할 디렉토리 
 $dir = $_GET['d']; 

 // 압축파일 이름 
 $zipfile = date('Y_m_d') . "_" . $dir . ".zip"; 

 $zip = new ZipArchive; 
 $res = $zip->open($zipfile, ZipArchive::CREATE); 
 if ($res === TRUE) {        
      dirZip($zip,$dir); 
      $zip->close(); 
      header("Location: down.php?f=$zipfile"); 
 } else { 
      echo "에러 코드: ".$res; 
 } 
 ?>